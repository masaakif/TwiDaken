using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TwiDaken;

namespace TwiDaken
{
    public partial class dlgTwitterOAuth : Form
    {
        public Auth au;

        public dlgTwitterOAuth()
        {
            InitializeComponent();
        }
        
        public dlgTwitterOAuth(ref Auth _au)
        {
            InitializeComponent();
            au = _au;
        }
        
        private void dlgTwitterOAuth_Activated(object sender, EventArgs e)
        {
            var settings = TwiDaken.Properties.ConsumerKeys.Default;
            au = new Auth((string)settings["ConsumerKey"], (string)settings["ConsumerSecret"]);
            au.GetRequestToken();
            txtAuthUrl.Text = au.GetAuthorizeUrl();
            System.Diagnostics.Process.Start(au.GetAuthorizeUrl());
        }

        private void txtPIN_TextChanged(object sender, EventArgs e)
        {
            if (txtPIN.Text.Length > 0) 
            {
                btnSendPIN.Enabled = true;
            }
            else
            {
                btnSendPIN.Enabled = false;
            }
        }

        private void btnSendPIN_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            label2.Text = "Authorizing...";
            System.Threading.Thread.Sleep(5000);
            au.GetAccessToken(txtPIN.Text);
            label2.Text = "Autorization Finished! Please close this dialog.";
            Cursor.Current = Cursors.Default;
            //AccessToken = au.AccessToken;
            //UserId = au.UserId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
