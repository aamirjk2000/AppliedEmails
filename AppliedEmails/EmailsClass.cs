using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MailKit.Net.Pop3;
using MimeKit;


namespace AppliedEmails
{
    public class EmailsClass
    {
        public UserProfile ProfileClass = new UserProfile();

        public static string GetMessageIP(MimeMessage _Message)
        {
            string _MessageIP = "";
            string _Received = _Message.Headers[HeaderId.Received];

            if (_Received != null)
            {
                int _First = _Received.IndexOf("(");
                int _Last = _Received.IndexOf(")");
                _MessageIP = _Received.Substring(_First + 2, (_Last - _First) - 3);
            }
            return _MessageIP;
        }

        public static int RemoveIPMessages(string _IP)
        {
            int _Result = 0;
            frmCounter MyCounter = new frmCounter();
            UserProfile ProfileClass = new UserProfile();


            MyCounter.Show();

            using (var emailClient = new Pop3Client())
            {
                emailClient.Connect(ProfileClass.Server);
                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");
                emailClient.Authenticate(ProfileClass.User, ProfileClass.Password);
                MyCounter.CounterBar.Maximum = emailClient.Count;

                for (int i = 0; i < emailClient.Count; i++)
                {
                    MyCounter.CounterBar.Value = i;
                    var message = emailClient.GetMessage(i);
                    var messageIP = GetMessageIP(message);
                    if (messageIP == _IP)
                    {
                        emailClient.DeleteMessageAsync(i);
                        _Result += 1;
                    }

                }
                emailClient.Disconnect(true);
            }

            MyCounter.Close();
            return _Result;
        }

        public static int RemoveDeletedMessages()
        {
            DataTable _DataTable = SQLiteClass.GetDataTable("IP_Address", "Nature=" + (int)SQLiteClass.Nature.Delete);

            int _Result = 0;
            frmCounter MyCounter = new frmCounter();
            UserProfile ProfileClass = new UserProfile();


            MyCounter.Show();

            using (var emailClient = new Pop3Client())
            {
                emailClient.Connect(ProfileClass.Server);
                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");
                emailClient.Authenticate(ProfileClass.User, ProfileClass.Password);
                MyCounter.CounterBar.Maximum = emailClient.Count;
                int Counter1 = emailClient.Count;
                string messageIP = "";

                for (int i = 0; i < emailClient.Count; i++)
                {
                    MyCounter.CounterBar.Value = i;
                    var message = emailClient.GetMessage(i);
                    messageIP = GetMessageIP(message);

                    if (DeleteListIP(messageIP, _DataTable.AsDataView()))
                    {
                        emailClient.DeleteMessage(i);
                    }
                }

                int Counter2 = emailClient.Count;

                emailClient.Disconnect(true);
                MyCounter.Close();
                MessageBox.Show((Counter2 - Counter1).ToString());
            }
            return _Result;
        }

        private static bool DeleteListIP(string _IP, DataView _DataView)
        {
            _DataView.RowFilter = "IP='" + _IP + "'";
            if (_DataView.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Client2Database(int maxCount)
        {
            // Retrive Emails from Email Pop3 Server and store them into a Database Table 'Emails'

            frmCounter _Counter = new frmCounter(); int Counter = 0; _Counter.Show();                    // Activate Counter Window
            DataTable _DataTable = SQLiteClass.GetDataTable("Emails");                                          // Data Table of
            DataView _DataView = _DataTable.AsDataView();                                                            // Data Table's View

            int ResultCount = 0;                                                                                                             // Count effected emails
            using (var emailClient = new Pop3Client())
            {
                emailClient.Connect(ProfileClass.Server);
                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");
                emailClient.Authenticate(ProfileClass.User, ProfileClass.Password);

                if (maxCount == -1) { maxCount = emailClient.Count; } 
                _Counter.CounterBar.Maximum = maxCount;

                for (int i = 0; i < emailClient.Count && i < maxCount; i++)
                {
                    _Counter.CounterBar.Value = Counter; Counter++;
                    var message = emailClient.GetMessage(i);
                    _DataView.RowFilter = "EmailID='" + message.MessageId + "'";
                    if (_DataView.Count == 0)
                    {
                        ResultCount++;
                        SQLiteClass.UpdateEmails(message, ProfileClass.User);
                    }
                }
                _Counter.Close();
            }
            return ResultCount;
        }


        //=========================================
    }
}
