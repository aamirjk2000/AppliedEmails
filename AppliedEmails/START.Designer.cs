namespace AppliedEmails
{
    partial class frmSTART
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListIPs = new System.Windows.Forms.ListView();
            this.mnuNature = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuWhiteList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlockList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteList = new System.Windows.Forms.ToolStripMenuItem();
            this.ListEmails = new System.Windows.Forms.ListBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtBCC = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTotalIPs = new System.Windows.Forms.Label();
            this.mnuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPolicy = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.pROCESSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmailsBulkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuIPDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNature.SuspendLayout();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(941, 37);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(199, 33);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(736, 29);
            this.txtUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User";
            // 
            // ListIPs
            // 
            this.ListIPs.ContextMenuStrip = this.mnuNature;
            this.ListIPs.HideSelection = false;
            this.ListIPs.Location = new System.Drawing.Point(16, 66);
            this.ListIPs.Name = "ListIPs";
            this.ListIPs.Size = new System.Drawing.Size(128, 425);
            this.ListIPs.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListIPs.TabIndex = 4;
            this.ListIPs.UseCompatibleStateImageBehavior = false;
            this.ListIPs.View = System.Windows.Forms.View.List;
            this.ListIPs.SelectedIndexChanged += new System.EventHandler(this.ListIPs_SelectedIndexChanged);
            // 
            // mnuNature
            // 
            this.mnuNature.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWhiteList,
            this.mnuBlockList,
            this.mnuDeleteList,
            this.toolStripSeparator1,
            this.mnuIPDelete});
            this.mnuNature.Name = "mnuNature";
            this.mnuNature.Size = new System.Drawing.Size(187, 98);
            // 
            // mnuWhiteList
            // 
            this.mnuWhiteList.Name = "mnuWhiteList";
            this.mnuWhiteList.Size = new System.Drawing.Size(186, 22);
            this.mnuWhiteList.Text = "White List";
            this.mnuWhiteList.Click += new System.EventHandler(this.mnuWhiteList_Click);
            // 
            // mnuBlockList
            // 
            this.mnuBlockList.Name = "mnuBlockList";
            this.mnuBlockList.Size = new System.Drawing.Size(186, 22);
            this.mnuBlockList.Text = "Block List";
            this.mnuBlockList.Click += new System.EventHandler(this.mnuBlockList_Click);
            // 
            // mnuDeleteList
            // 
            this.mnuDeleteList.Name = "mnuDeleteList";
            this.mnuDeleteList.Size = new System.Drawing.Size(186, 22);
            this.mnuDeleteList.Text = "Delete List";
            this.mnuDeleteList.Click += new System.EventHandler(this.mnuDeleteList_Click);
            // 
            // ListEmails
            // 
            this.ListEmails.FormattingEnabled = true;
            this.ListEmails.Location = new System.Drawing.Point(199, 66);
            this.ListEmails.Name = "ListEmails";
            this.ListEmails.Size = new System.Drawing.Size(817, 69);
            this.ListEmails.TabIndex = 5;
            this.ListEmails.TabIndexChanged += new System.EventHandler(this.ListEmails_TabIndexChanged);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(199, 141);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(817, 20);
            this.txtFrom.TabIndex = 6;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(199, 167);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(817, 20);
            this.txtCC.TabIndex = 7;
            // 
            // txtBCC
            // 
            this.txtBCC.Location = new System.Drawing.Point(199, 193);
            this.txtBCC.Name = "txtBCC";
            this.txtBCC.Size = new System.Drawing.Size(817, 20);
            this.txtBCC.TabIndex = 8;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(199, 219);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(817, 20);
            this.txtSubject.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "BCC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Subject";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(150, 245);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(862, 246);
            this.txtBody.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Emails";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(13, 498);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(65, 17);
            this.lblMessage.TabIndex = 16;
            this.lblMessage.Text = "Message";
            // 
            // lblTotalIPs
            // 
            this.lblTotalIPs.AutoSize = true;
            this.lblTotalIPs.Location = new System.Drawing.Point(18, 36);
            this.lblTotalIPs.Name = "lblTotalIPs";
            this.lblTotalIPs.Size = new System.Drawing.Size(35, 13);
            this.lblTotalIPs.TabIndex = 17;
            this.lblTotalIPs.Text = "label7";
            // 
            // mnuSetup
            // 
            this.mnuSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfile,
            this.mnuTestConnection});
            this.mnuSetup.Name = "mnuSetup";
            this.mnuSetup.Size = new System.Drawing.Size(52, 20);
            this.mnuSetup.Text = "SETUP";
            // 
            // mnuProfile
            // 
            this.mnuProfile.Name = "mnuProfile";
            this.mnuProfile.Size = new System.Drawing.Size(177, 22);
            this.mnuProfile.Text = "Emails Profile";
            this.mnuProfile.Click += new System.EventHandler(this.mnuProfile_Click);
            // 
            // mnuTestConnection
            // 
            this.mnuTestConnection.Name = "mnuTestConnection";
            this.mnuTestConnection.Size = new System.Drawing.Size(177, 22);
            this.mnuTestConnection.Text = "Test DB Connection";
            this.mnuTestConnection.Click += new System.EventHandler(this.mnuTestConnection_Click);
            // 
            // mnuEmails
            // 
            this.mnuEmails.Name = "mnuEmails";
            this.mnuEmails.Size = new System.Drawing.Size(59, 20);
            this.mnuEmails.Text = "EMAILS";
            // 
            // menuPolicy
            // 
            this.menuPolicy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteListToolStripMenuItem,
            this.blockListToolStripMenuItem,
            this.deleteListToolStripMenuItem});
            this.menuPolicy.Name = "menuPolicy";
            this.menuPolicy.Size = new System.Drawing.Size(59, 20);
            this.menuPolicy.Text = "POLICY";
            // 
            // whiteListToolStripMenuItem
            // 
            this.whiteListToolStripMenuItem.Name = "whiteListToolStripMenuItem";
            this.whiteListToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.whiteListToolStripMenuItem.Text = "White List";
            // 
            // blockListToolStripMenuItem
            // 
            this.blockListToolStripMenuItem.Name = "blockListToolStripMenuItem";
            this.blockListToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.blockListToolStripMenuItem.Text = "Block List";
            // 
            // deleteListToolStripMenuItem
            // 
            this.deleteListToolStripMenuItem.Name = "deleteListToolStripMenuItem";
            this.deleteListToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteListToolStripMenuItem.Text = "Delete List";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(41, 20);
            this.menuExit.Text = "EXIT";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetup,
            this.mnuEmails,
            this.pROCESSToolStripMenuItem,
            this.menuPolicy,
            this.menuExit});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(1024, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "MainMenu";
            // 
            // pROCESSToolStripMenuItem
            // 
            this.pROCESSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteEmailsBulkToolStripMenuItem});
            this.pROCESSToolStripMenuItem.Name = "pROCESSToolStripMenuItem";
            this.pROCESSToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.pROCESSToolStripMenuItem.Text = "PROCESS";
            // 
            // deleteEmailsBulkToolStripMenuItem
            // 
            this.deleteEmailsBulkToolStripMenuItem.Name = "deleteEmailsBulkToolStripMenuItem";
            this.deleteEmailsBulkToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.deleteEmailsBulkToolStripMenuItem.Text = "Remove Deleted Message";
            this.deleteEmailsBulkToolStripMenuItem.Click += new System.EventHandler(this.deleteEmailsBulkToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // mnuIPDelete
            // 
            this.mnuIPDelete.Name = "mnuIPDelete";
            this.mnuIPDelete.Size = new System.Drawing.Size(186, 22);
            this.mnuIPDelete.Text = "Delete All IP Message";
            this.mnuIPDelete.Click += new System.EventHandler(this.mnuIPDelete_Click);
            // 
            // frmSTART
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 524);
            this.Controls.Add(this.lblTotalIPs);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtBCC);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.ListEmails);
            this.Controls.Add(this.ListIPs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmSTART";
            this.Text = "APPLIED EMAILS";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuNature.ResumeLayout(false);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListIPs;
        private System.Windows.Forms.ListBox ListEmails;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtBCC;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTotalIPs;
        private System.Windows.Forms.ToolStripMenuItem mnuSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuProfile;
        private System.Windows.Forms.ToolStripMenuItem mnuTestConnection;
        private System.Windows.Forms.ToolStripMenuItem mnuEmails;
        private System.Windows.Forms.ToolStripMenuItem menuPolicy;
        private System.Windows.Forms.ToolStripMenuItem whiteListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ContextMenuStrip mnuNature;
        private System.Windows.Forms.ToolStripMenuItem mnuWhiteList;
        private System.Windows.Forms.ToolStripMenuItem mnuBlockList;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteList;
        private System.Windows.Forms.ToolStripMenuItem pROCESSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmailsBulkToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuIPDelete;
    }
}

