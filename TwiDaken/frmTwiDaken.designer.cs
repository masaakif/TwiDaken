namespace TwiDaken
{
    partial class frmTwiDaken
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTwiDaken));
            this.btnTweet = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain_tsmnuRemoveConfigFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMain_tsmnuExitTwiDaken = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain_tsmnuAuthentication = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain_tsmnuSetIgnoreAppList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain_tsmnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwCounts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.icoTwiDaken = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmnuTwiDaken = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuTwiDaken_tsmnuOpenMainWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuTwiDaken_tsmnuMinimizeMainWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuTwiDaken_tsmnuUpdateToTwitter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuTwiDaken_tsmnuAuthentication = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuTwiDaken_tsmnuSetIgnoreAppList = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuTwiDaken_tsmnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuTwiDaken_tsmnuExitTwiDaken = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.cmnuTwiDaken.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTweet
            // 
            resources.ApplyResources(this.btnTweet, "btnTweet");
            this.btnTweet.Name = "btnTweet";
            this.btnTweet.UseVisualStyleBackColor = true;
            this.btnTweet.Click += new System.EventHandler(this.btnTweet_Click);
            // 
            // mnuMain
            // 
            resources.ApplyResources(this.mnuMain, "mnuMain");
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolToolStripMenuItem});
            this.mnuMain.Name = "mnuMain";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain_tsmnuRemoveConfigFile,
            this.toolStripSeparator4,
            this.mnuMain_tsmnuExitTwiDaken});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // mnuMain_tsmnuRemoveConfigFile
            // 
            resources.ApplyResources(this.mnuMain_tsmnuRemoveConfigFile, "mnuMain_tsmnuRemoveConfigFile");
            this.mnuMain_tsmnuRemoveConfigFile.Name = "mnuMain_tsmnuRemoveConfigFile";
            this.mnuMain_tsmnuRemoveConfigFile.Click += new System.EventHandler(this.mnuMain_tsmnuRemoveConfigFile_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // mnuMain_tsmnuExitTwiDaken
            // 
            resources.ApplyResources(this.mnuMain_tsmnuExitTwiDaken, "mnuMain_tsmnuExitTwiDaken");
            this.mnuMain_tsmnuExitTwiDaken.Name = "mnuMain_tsmnuExitTwiDaken";
            this.mnuMain_tsmnuExitTwiDaken.Click += new System.EventHandler(this.mnuMain_tsmnuExitTwiDaken_Click);
            // 
            // toolToolStripMenuItem
            // 
            resources.ApplyResources(this.toolToolStripMenuItem, "toolToolStripMenuItem");
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain_tsmnuAuthentication,
            this.mnuMain_tsmnuSetIgnoreAppList,
            this.mnuMain_tsmnuOptions});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            // 
            // mnuMain_tsmnuAuthentication
            // 
            resources.ApplyResources(this.mnuMain_tsmnuAuthentication, "mnuMain_tsmnuAuthentication");
            this.mnuMain_tsmnuAuthentication.Name = "mnuMain_tsmnuAuthentication";
            this.mnuMain_tsmnuAuthentication.Click += new System.EventHandler(this.mnuMain_tsmnuAuthentication_Click);
            // 
            // mnuMain_tsmnuSetIgnoreAppList
            // 
            resources.ApplyResources(this.mnuMain_tsmnuSetIgnoreAppList, "mnuMain_tsmnuSetIgnoreAppList");
            this.mnuMain_tsmnuSetIgnoreAppList.Name = "mnuMain_tsmnuSetIgnoreAppList";
            // 
            // mnuMain_tsmnuOptions
            // 
            resources.ApplyResources(this.mnuMain_tsmnuOptions, "mnuMain_tsmnuOptions");
            this.mnuMain_tsmnuOptions.Name = "mnuMain_tsmnuOptions";
            // 
            // lvwCounts
            // 
            resources.ApplyResources(this.lvwCounts, "lvwCounts");
            this.lvwCounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvwCounts.Name = "lvwCounts";
            this.lvwCounts.UseCompatibleStateImageBehavior = false;
            this.lvwCounts.View = System.Windows.Forms.View.Details;
            this.lvwCounts.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwCounts_ColumnClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // icoTwiDaken
            // 
            resources.ApplyResources(this.icoTwiDaken, "icoTwiDaken");
            this.icoTwiDaken.ContextMenuStrip = this.cmnuTwiDaken;
            this.icoTwiDaken.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.icoTwiDaken_MouseDoubleClick);
            // 
            // cmnuTwiDaken
            // 
            resources.ApplyResources(this.cmnuTwiDaken, "cmnuTwiDaken");
            this.cmnuTwiDaken.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuTwiDaken_tsmnuOpenMainWindow,
            this.cmnuTwiDaken_tsmnuMinimizeMainWindow,
            this.toolStripSeparator3,
            this.cmnuTwiDaken_tsmnuUpdateToTwitter,
            this.toolStripSeparator1,
            this.cmnuTwiDaken_tsmnuAuthentication,
            this.cmnuTwiDaken_tsmnuSetIgnoreAppList,
            this.cmnuTwiDaken_tsmnuOptions,
            this.toolStripSeparator2,
            this.cmnuTwiDaken_tsmnuExitTwiDaken});
            this.cmnuTwiDaken.Name = "cmnuTwiDaken";
            // 
            // cmnuTwiDaken_tsmnuOpenMainWindow
            // 
            resources.ApplyResources(this.cmnuTwiDaken_tsmnuOpenMainWindow, "cmnuTwiDaken_tsmnuOpenMainWindow");
            this.cmnuTwiDaken_tsmnuOpenMainWindow.Name = "cmnuTwiDaken_tsmnuOpenMainWindow";
            this.cmnuTwiDaken_tsmnuOpenMainWindow.Click += new System.EventHandler(this.cmnuTwiDaken_tsmnuOpenMainWindow_Click);
            // 
            // cmnuTwiDaken_tsmnuMinimizeMainWindow
            // 
            resources.ApplyResources(this.cmnuTwiDaken_tsmnuMinimizeMainWindow, "cmnuTwiDaken_tsmnuMinimizeMainWindow");
            this.cmnuTwiDaken_tsmnuMinimizeMainWindow.Name = "cmnuTwiDaken_tsmnuMinimizeMainWindow";
            this.cmnuTwiDaken_tsmnuMinimizeMainWindow.Click += new System.EventHandler(this.cmnuTwiDaken_tsmnuMinimizeMainWindow_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // cmnuTwiDaken_tsmnuUpdateToTwitter
            // 
            resources.ApplyResources(this.cmnuTwiDaken_tsmnuUpdateToTwitter, "cmnuTwiDaken_tsmnuUpdateToTwitter");
            this.cmnuTwiDaken_tsmnuUpdateToTwitter.Name = "cmnuTwiDaken_tsmnuUpdateToTwitter";
            this.cmnuTwiDaken_tsmnuUpdateToTwitter.Click += new System.EventHandler(this.cmnuTwiDaken_tsmnuUpdateToTwitter_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // cmnuTwiDaken_tsmnuAuthentication
            // 
            resources.ApplyResources(this.cmnuTwiDaken_tsmnuAuthentication, "cmnuTwiDaken_tsmnuAuthentication");
            this.cmnuTwiDaken_tsmnuAuthentication.Name = "cmnuTwiDaken_tsmnuAuthentication";
            this.cmnuTwiDaken_tsmnuAuthentication.Click += new System.EventHandler(this.cmnuTwiDaken_tsmnuAuthentication_Click);
            // 
            // cmnuTwiDaken_tsmnuSetIgnoreAppList
            // 
            resources.ApplyResources(this.cmnuTwiDaken_tsmnuSetIgnoreAppList, "cmnuTwiDaken_tsmnuSetIgnoreAppList");
            this.cmnuTwiDaken_tsmnuSetIgnoreAppList.Name = "cmnuTwiDaken_tsmnuSetIgnoreAppList";
            // 
            // cmnuTwiDaken_tsmnuOptions
            // 
            resources.ApplyResources(this.cmnuTwiDaken_tsmnuOptions, "cmnuTwiDaken_tsmnuOptions");
            this.cmnuTwiDaken_tsmnuOptions.Name = "cmnuTwiDaken_tsmnuOptions";
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // cmnuTwiDaken_tsmnuExitTwiDaken
            // 
            resources.ApplyResources(this.cmnuTwiDaken_tsmnuExitTwiDaken, "cmnuTwiDaken_tsmnuExitTwiDaken");
            this.cmnuTwiDaken_tsmnuExitTwiDaken.Name = "cmnuTwiDaken_tsmnuExitTwiDaken";
            this.cmnuTwiDaken_tsmnuExitTwiDaken.Click += new System.EventHandler(this.cmnuTwiDaken_tsmnuExitTwiDaken_Click);
            // 
            // frmTwiDaken
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvwCounts);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.btnTweet);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmTwiDaken";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTwiDaken_FormClosing);
            this.Resize += new System.EventHandler(this.frmTwiDaken_Resize);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.cmnuTwiDaken.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTweet;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMain_tsmnuAuthentication;
        private System.Windows.Forms.ToolStripMenuItem mnuMain_tsmnuOptions;
        private System.Windows.Forms.ListView lvwCounts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.NotifyIcon icoTwiDaken;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip cmnuTwiDaken;
        private System.Windows.Forms.ToolStripMenuItem cmnuTwiDaken_tsmnuOpenMainWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuMain_tsmnuSetIgnoreAppList;
        private System.Windows.Forms.ToolStripMenuItem cmnuTwiDaken_tsmnuMinimizeMainWindow;
        private System.Windows.Forms.ToolStripMenuItem cmnuTwiDaken_tsmnuOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmnuTwiDaken_tsmnuUpdateToTwitter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmnuTwiDaken_tsmnuSetIgnoreAppList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmnuTwiDaken_tsmnuExitTwiDaken;
        private System.Windows.Forms.ToolStripMenuItem cmnuTwiDaken_tsmnuAuthentication;
        private System.Windows.Forms.ToolStripMenuItem mnuMain_tsmnuExitTwiDaken;
        private System.Windows.Forms.ToolStripMenuItem mnuMain_tsmnuRemoveConfigFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

