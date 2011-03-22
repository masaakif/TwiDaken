namespace TwiDaken
{
    partial class dlgTwitterOAuth
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgTwitterOAuth));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAuthUrl = new System.Windows.Forms.TextBox();
            this.btnSendPIN = new System.Windows.Forms.Button();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.TabStop = false;
            // 
            // txtAuthUrl
            // 
            this.txtAuthUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtAuthUrl, "txtAuthUrl");
            this.txtAuthUrl.Name = "txtAuthUrl";
            this.txtAuthUrl.ReadOnly = true;
            this.txtAuthUrl.TabStop = false;
            // 
            // btnSendPIN
            // 
            resources.ApplyResources(this.btnSendPIN, "btnSendPIN");
            this.btnSendPIN.Name = "btnSendPIN";
            this.btnSendPIN.UseVisualStyleBackColor = true;
            this.btnSendPIN.Click += new System.EventHandler(this.btnSendPIN_Click);
            // 
            // txtPIN
            // 
            resources.ApplyResources(this.txtPIN, "txtPIN");
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.TextChanged += new System.EventHandler(this.txtPIN_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // dlgTwitterOAuth
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.btnSendPIN);
            this.Controls.Add(this.txtAuthUrl);
            this.Controls.Add(this.textBox1);
            this.Name = "dlgTwitterOAuth";
            this.Load += new System.EventHandler(this.dlgTwitterOAuth_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtAuthUrl;
        private System.Windows.Forms.Button btnSendPIN;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;

    }
}