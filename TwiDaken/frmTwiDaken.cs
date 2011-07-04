using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TwiDaken;
using WindowsAPIs;
using System.Collections;



namespace TwiDaken
{
    public partial class frmTwiDaken : Form
    {
        //private Configuration cfg;

        private List<ModuleCountPair> lm = new List<ModuleCountPair>();
        
        /*
        private string AccessToken = "";
        private string AccessTokenSecret = "";
        private string UserId = "";
        private string ScreenName = "";
         */

        Auth au;
        Utils ut = new Utils();

        public frmTwiDaken()
        {            
            KeybordCapture.KeyDown += new EventHandler<KeybordCapture.KeybordCaptureEventArgs>(Global_KeyDown);
            MouseCapture.MouseDown += new EventHandler<MouseCapture.MouseCaptureEventArgs>(Global_MouseDown);
            MouseCapture.MouseWheel += new EventHandler<MouseCapture.MouseCaptureEventArgs>(Global_MouseWheel);

            InitializeComponent();
            btnTweet.Enabled = false;

            this.Text = "TwiDaken " + "version " + Application.ProductVersion + " hogehoge";
            icoTwiDaken.Text = this.Text;
        }

        private void updateListViewCounts(ref ModuleCountPair mcp)
        {
            bool isExist = false;

            foreach (ListViewItem item in lvwCounts.Items)
            {
                if (item.SubItems[0].Text == mcp.getModuleName())
                {
                    item.SubItems[1].Text = mcp.getKeyCount().ToString();
                    item.SubItems[3].Text = mcp.getLastTime();
                    item.SubItems[4].Text = mcp.getMouseDownCount().ToString();
                    item.SubItems[5].Text = mcp.getMouseWheelCount().ToString();
                    item.SubItems[6].Text = mcp.getPath();

                    isExist = true;
                }
            }

            if (isExist == false)
            {
                string[] ary = { mcp.getModuleName(), mcp.getKeyCount().ToString(),mcp.getStartTime(), 
                                 mcp.getLastTime(), mcp.getMouseDownCount().ToString(), mcp.getMouseWheelCount().ToString(),
                                 mcp.getPath() };
                lvwCounts.Items.Add(new ListViewItem(ary));
            }
        }

        private void Global_MouseDown(object sender, MouseCapture.MouseCaptureEventArgs e)
        {
            KeyMouseDown(ActionType.MouseDown);
        }

        private void Global_MouseWheel(object sender, MouseCapture.MouseCaptureEventArgs e)
        {
            KeyMouseDown(ActionType.MouseWheel);
        }

        private void Global_KeyDown(object sender, KeybordCapture.KeybordCaptureEventArgs e)
        {
            KeyMouseDown(ActionType.KeyDown);
        }

        private void KeyMouseDown(ActionType a)
        {
            ModuleInfo mi = ut.getActiveWindowModuleName();
            ModuleCountPair mcp = lm.Find(delegate(ModuleCountPair item)
            { return item.getModuleName() == mi.moduleName; });
            if (mcp == null)
            {
                mcp = new ModuleCountPair(mi.moduleName);
                lm.Add(mcp);
            }

            mcp.inc(mi.moduleName, a);
            mcp.setPath(mi.fullPath);
            updateListViewCounts(ref mcp);
        }

        private void btnTweet_Click(object sender, EventArgs e)
        {
            updateToTwitter();
        }

        private void cmnuTwiDaken_tsmnuUpdateToTwitter_Click(object sender, EventArgs e)
        {
            updateToTwitter();
        }

        private void updateToTwitter()
        {
            int total = 0;
            foreach (ModuleCountPair mcp in lm)
            {
                Dictionary<string, string> parameters = new Dictionary<string, string>();
                string tw = mcp.getModuleName() + " : Count of key down = " + mcp.getKeyCount().ToString();
                total += mcp.getKeyCount();
                parameters.Clear();
                parameters.Add("status", au.UrlEncode(tw));
                au.Post("http://twitter.com/statuses/update.xml", parameters);
            }

            Dictionary<string, string> parameters2 = new Dictionary<string, string>();
            string tw2 = "Total Count of key down = " + total.ToString();
            parameters2.Clear();
            parameters2.Add("status", au.UrlEncode(tw2));
            au.Post("http://twitter.com/statuses/update.xml", parameters2);
        }

        private void frmTwiDaken_FormClosing(object sender, FormClosingEventArgs e)
        {
            icoTwiDaken.Visible = false;
        }

        private void mnuMain_tsmnuExitTwiDaken_Click(object sender, EventArgs e)
        {
            closeTwiDaken();
        }

        private void cmnuTwiDaken_tsmnuExitTwiDaken_Click(object sender, EventArgs e)
        {
            closeTwiDaken();
        }

        private void AuthenticateWithTwitter()
        {
            dlgTwitterOAuth d = new dlgTwitterOAuth(ref au);
            d.ShowDialog(this);
            au = d.au;
            d.Close();
            d.Dispose();
            if (au != null)
            {
                btnTweet.Enabled = true;
                cmnuTwiDaken_tsmnuUpdateToTwitter.Enabled = true;
            }
        }

        private void mnuMain_tsmnuAuthentication_Click(object sender, EventArgs e)
        {
            AuthenticateWithTwitter();
        }

        private void cmnuTwiDaken_tsmnuAuthentication_Click(object sender, EventArgs e)
        {
            AuthenticateWithTwitter();
        }

        private void frmTwiDaken_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                this.cmnuTwiDaken_tsmnuMinimizeMainWindow.Visible = false;
                this.cmnuTwiDaken_tsmnuOpenMainWindow.Visible = true;
            }
            else
            {
                this.ShowInTaskbar = true;
                this.cmnuTwiDaken_tsmnuMinimizeMainWindow.Visible = true;
                this.cmnuTwiDaken_tsmnuOpenMainWindow.Visible = false;
            }
        }

        private void closeTwiDaken()
        {

            icoTwiDaken.Visible = false;
            this.Close();
        }

        private void cmnuTwiDaken_tsmnuOpenMainWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void cmnuTwiDaken_tsmnuMinimizeMainWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mnuMain_tsmnuRemoveConfigFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!TODO!", "Caption??", MessageBoxButtons.YesNo); /* TODO : Should implement RemoveConfigFile */
            if (au == null)
            {
                btnTweet.Enabled = false;
                cmnuTwiDaken_tsmnuUpdateToTwitter.Enabled = false;
            }
        }

        private void lvwCounts_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            switch (lvwCounts.Sorting)
            {
                case SortOrder.Ascending:
                    lvwCounts.Sorting = SortOrder.Descending;
                    break;
                default:
                    lvwCounts.Sorting = SortOrder.Ascending;
                    break;
            }
            lvwCounts.ListViewItemSorter = new ListViewItemComparer(e.Column, lvwCounts.Sorting);
            lvwCounts.Sort();
        }

        // Configuration files should be under application directory.
        private void writeConfig()
        {
            // TODO : writeConfig
        }

        private void readConfig()
        {
            // TODO : readConfig
        }

        private void deleteConfig()
        {
            // TODO : deleteConfig
        }

        private void icoTwiDaken_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                case FormWindowState.Maximized:
                    this.WindowState = FormWindowState.Minimized;
                    break;
                case FormWindowState.Minimized:
                    this.WindowState = FormWindowState.Normal;
                    break;
            }            
        }
    }

    internal enum ActionType
    {
        KeyDown,
        MouseDown,
        MouseWheel,
        MouseMove
    }

    internal class Configuration
    {
        public Configuration()
        {
        }
    }

    internal class ModuleCountPair
    {
        private string moduleName = "";

        private int keycount = 0;
        private int mousebtncount = 0;
        // TODO : private int mousemvdistance = 0;
        private int mousewheeldistance = 0;

        private DateTime dt_start;
        private DateTime dt_last;

        private string pathName = "";


        public ModuleCountPair(string _module)
        {
            if (moduleName == "")
            {
                moduleName = _module;
                dt_start = DateTime.Now;
            }
        }

        public string getModuleName() { return moduleName; }
        public int getKeyCount() { return keycount; }
        public int getMouseDownCount() { return mousebtncount; }
        public int getMouseWheelCount() { return mousewheeldistance; }
        public string getStartTime() { return dt_start.ToShortTimeString(); }
        public string getLastTime() { return dt_last.ToShortTimeString(); }
        public string getPath() { return pathName; }
        public void setPath(string _path) { pathName = _path; }

        public void inc(string _module, string _path, ActionType a)
        {
            if (moduleName == _module)
            {

            }
        }

        public void inc(string _module, ActionType a)
        {
            if (moduleName == _module)
            {
                inc(a);
            }
        }

        public void inc(ActionType a)
        {
            if (moduleName != "")
            {
                dt_last = DateTime.Now;
                switch (a)
                {
                    case ActionType.KeyDown:
                        keycount++;
                        break;
                    case ActionType.MouseDown:
                        mousebtncount++;
                        break;
                    case ActionType.MouseWheel:
                        mousewheeldistance++;
                        break;
                    default:
                        // Nothing to do
                        break;
                }
            }
        }
    }
    
    public class ListViewItemComparer : IComparer
    {
        private int _column;
        private SortOrder _so;

        public ListViewItemComparer(int col, SortOrder so)
        {
            _column = col;
            _so = so;
        }

        public int Compare(object x, object y)
        {
            ListViewItem itemx = (ListViewItem)x;
            ListViewItem itemy = (ListViewItem)y;
            
            int nx = 0;
            int ny = 0;
            if (int.TryParse(itemx.SubItems[_column].Text, out nx) && int.TryParse(itemy.SubItems[_column].Text, out ny))
            {
                // compare x and y as numeric value
                if (_so == SortOrder.Ascending)
                {
                    return (nx < ny) ? 1 : -1;
                }
                else
                {
                    return (nx < ny) ? -1 : 1;
                }
            }
            else
            {
                // Compare x and y as a string value
                if (_so == SortOrder.Ascending)
                {
                    return string.Compare(itemx.SubItems[_column].Text,
                        itemy.SubItems[_column].Text);
                }
                else
                {
                    return string.Compare(itemy.SubItems[_column].Text,
                        itemx.SubItems[_column].Text);
                }
            }
        }
    }

}
