using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwiDaken
{
    static class KeybordCapture {
        internal class Native {
            [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
            public struct KBDLLHOOKSTRUCT {
                public int vkCode;
                public int scanCode;
                public int flags;
                public int time;
                public IntPtr dwExtraInfo;
            }
            [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
            public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);
            [System.Runtime.InteropServices.DllImport("kernel32.dll")]
            public static extern IntPtr GetModuleHandle(string lpModuleName);
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, int dwThreadId);
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern IntPtr CallNextHookEx(IntPtr hHook, int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern bool UnhookWindowsHookEx(IntPtr hHook);

            public const int WH_KEYBOARD_LL = 13;
            public const int HC_ACTION = 0;
            public const int WM_KEYDOWN = 0x0100;
            public const int WM_KEYUP = 0x0101;
            public const int WM_SYSKEYDOWN = 0x0104;
            public const int WM_SYSKEYUP = 0x0105;
        }

        public sealed class KeybordCaptureEventArgs : EventArgs {
            private int m_keyCode;
            private int m_scanCode;
            private int m_flags;
            private int m_time;
            private bool m_cancel;

            internal KeybordCaptureEventArgs(Native.KBDLLHOOKSTRUCT keyData) {
                this.m_keyCode = keyData.vkCode;
                this.m_scanCode = keyData.scanCode;
                this.m_flags = keyData.flags;
                this.m_time = keyData.time;
                this.m_cancel = false;
            }

            public int KeyCode { get { return this.m_keyCode; } }
            public int ScanCode { get { return this.m_scanCode; } }
            public int Flags { get { return this.m_flags; } }
            public int Time { get { return this.m_time; } }
            public bool Cancel {
                set { this.m_cancel = value; }
                get { return this.m_cancel; }
            }
        }

        private static IntPtr s_hook;
        private static Native.LowLevelKeyboardProc s_proc;
        public static event EventHandler<KeybordCaptureEventArgs> SysKeyDown;
        public static event EventHandler<KeybordCaptureEventArgs> KeyDown;
        public static event EventHandler<KeybordCaptureEventArgs> SysKeyUp;
        public static event EventHandler<KeybordCaptureEventArgs> KeyUp;
        static KeybordCapture() {
            s_hook = Native.SetWindowsHookEx(Native.WH_KEYBOARD_LL,
                s_proc = new Native.LowLevelKeyboardProc(LowLevelKeyboardProc),
                System.Runtime.InteropServices.Marshal.GetHINSTANCE(typeof(KeybordCapture).Module),
                //Native.GetModuleHandle(null),
                0);
            AppDomain.CurrentDomain.DomainUnload += delegate
            {
                if(s_hook != IntPtr.Zero)
                    Native.UnhookWindowsHookEx(s_hook);
            };
        }

        static IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, ref Native.KBDLLHOOKSTRUCT lParam) {
            bool cancel = false;
            if(nCode == Native.HC_ACTION) {
                KeybordCaptureEventArgs e = new KeybordCaptureEventArgs(lParam);
                switch(wParam.ToInt32()) {
                    case Native.WM_KEYDOWN:
                        if(KeyDown != null)
                            KeyDown(null, e);
                        break;
                    case Native.WM_KEYUP:
                        if(KeyUp != null)
                            KeyUp(null, e);
                        break;
                    case Native.WM_SYSKEYDOWN:
                        if(SysKeyDown != null)
                            SysKeyDown(null, e);
                        break;
                    case Native.WM_SYSKEYUP:
                        if(SysKeyUp != null)
                            SysKeyUp(null, e);
                        break;
                }
                cancel = e.Cancel;
            }
            return cancel ? (IntPtr)1 : Native.CallNextHookEx(s_hook, nCode, wParam, ref lParam);
        }

        public static bool IsCapture { get { return s_hook != IntPtr.Zero; } }
    }
}
