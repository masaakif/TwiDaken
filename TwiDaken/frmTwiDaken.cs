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


namespace TwiDaken
{
    public partial class frmTwiDaken : Form
    {
        private class ModuleCountPair
        {
            string moduleName = "";
            int count = 0;

            public ModuleCountPair(string _module)
            {
                if (moduleName == "")
                {
                    moduleName = _module;
                }
            }

            public string getModuleName()
            {
                return moduleName;
            }

            public int getCount()
            {
                return count;
            }

            public void inc(string _module)
            {
                if (moduleName == _module)
                {
                    count++;
                }
            }

            public void inc()
            {
                if (moduleName != "")
                {
                    count++;
                }
            }
        }

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
            InitializeComponent();
            btnTweet.Enabled = false;
            this.Text = "TwiDaken " + "version " + Application.ProductVersion;
        }

        private void Global_KeyDown(object sender, KeybordCapture.KeybordCaptureEventArgs e)
        {
            string _module = ut.getActiveWindowModuleName();
            ModuleCountPair mcp = lm.Find(delegate(ModuleCountPair item)
                                    {return item.getModuleName() == _module;});
            if (mcp == null)
            {
                mcp = new ModuleCountPair(_module);
                lm.Add(mcp);
            }

            mcp.inc(_module);

            bool isExist = false;
            foreach(ListViewItem item in lvwCounts.Items)
            {
                if (item.SubItems[0].Text == _module)
                {
                    item.SubItems[1].Text = mcp.getCount().ToString();
                    isExist = true;
                }
            }
            if (isExist == false)
            {
                string[] ary = { _module, mcp.getCount().ToString() };
                lvwCounts.Items.Add(new ListViewItem(ary));
            }
        }

        private void authenticationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgTwitterOAuth d = new dlgTwitterOAuth(ref au);
            d.ShowDialog(this);
            au = d.au;
            d.Dispose();
            if (au != null)
            {
                btnTweet.Enabled = true;
            }
        }

        private void btnTweet_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (ModuleCountPair mcp in lm)
            {
                Dictionary<string, string> parameters = new Dictionary<string, string>();
                string tw = mcp.getModuleName() + " : Count of key down = " + mcp.getCount().ToString();
                total += mcp.getCount();
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
    }
}
