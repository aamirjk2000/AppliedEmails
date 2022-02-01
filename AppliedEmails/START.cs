using MimeKit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AppliedEmails
{

    public partial class frmSTART : Form
    {
        int EmailCounter = 10;

        public List<MimeMessage> MyEmails = new List<MimeMessage>();
        public EmailsClass MyEmailClass = new EmailsClass();
        public long TotalEmails = 0;


        public frmSTART()
        {
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuProfile_Click(object sender, EventArgs e)
        {
            frmProfile ThisForm = new frmProfile();
            ThisForm.ShowDialog();

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            UserProfile ProfileClass = new UserProfile();
            txtUser.Text = ProfileClass.User;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            EmailsClass _EmailsClass = new EmailsClass();                                           // Connect with Email Server 
            TotalEmails = _EmailsClass.Client2Database(EmailCounter);
        }

        private void ListIPs_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRefresh_Click(null, null);
        }

        private void ListEmails_TabIndexChanged(object sender, EventArgs e)
        {



        }

        //private void ViewEmail(MimeMessage _EmailMessage)
        //{
        //    txtFrom.Text = _EmailMessage.From.ToString();
        //    txtCC.Text = _EmailMessage.Cc.ToString();
        //    txtBCC.Text = _EmailMessage.Bcc.ToString();
        //    txtSubject.Text = _EmailMessage.Subject.ToString();
        //    if (_EmailMessage.TextBody != null) { txtBody.Text = _EmailMessage.TextBody; } else { txtBody.Text = string.Empty; }
        //}

        private void mnuTestConnection_Click(object sender, EventArgs e)
        {
            SQLiteConnection _Connection = SQLiteClass.AppliedConnection();
            MessageBox.Show(_Connection.State.ToString());
        }

        #region White, Block, & Delete List

        private void mnuWhiteList_Click(object sender, EventArgs e)
        {
            string CurrentIP = ListIPs.SelectedItems[0].Text;
            int _Nature = (int)SQLiteClass.Nature.White;
            SQLiteClass.SetNature(CurrentIP, _Nature);
        }

        private void mnuBlockList_Click(object sender, EventArgs e)
        {
            string CurrentIP = ListIPs.SelectedItems[0].Text;
            int _Nature = (int)SQLiteClass.Nature.Block;
            SQLiteClass.SetNature(CurrentIP, _Nature);
        }

        private void mnuDeleteList_Click(object sender, EventArgs e)
        {
            string CurrentIP = "";
            int _Nature = 0;

            //for (int i = 0; i < emailClient.Count; i++)

            for (int i = 0; i < ListIPs.SelectedItems.Count; i++)
            {
                CurrentIP = ListIPs.SelectedItems[i].Text;
                _Nature = (int)SQLiteClass.Nature.Delete;
                SQLiteClass.SetNature(CurrentIP, _Nature);
            }
        }

        #endregion

        #region Remove Email messages from pop3 Server

        private void deleteEmailsBulkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailsClass.RemoveDeletedMessages();
        }

        private void mnuIPDelete_Click(object sender, EventArgs e)
        {
            int Count = EmailsClass.RemoveIPMessages(ListIPs.SelectedItems[0].Text);
            MessageBox.Show(Count.ToString());
        }

        #endregion

    }
}
