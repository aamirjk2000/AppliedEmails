using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using MimeKit;

namespace AppliedEmails
{
    public class SQLiteClass
    {



        #region SQLDatabase Connection and Table
        public static SQLiteConnection AppliedConnection()
        {
            SQLiteConnection sqlite_conn;
            string DB_Path = Application.StartupPath + "\\Data\\AppliedEmails.db";
            sqlite_conn = new SQLiteConnection("Data Source=" + DB_Path);  //+ " Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try { sqlite_conn.Open(); }
            catch (Exception ex)
            {
                MessageBox.Show("DataBase Connection is not being established \r" + ex.Message, "ERROR");
            }
            return sqlite_conn;
        }
        public static DataTable GetDataTable(string _TableName)
        {
            DataTable _DataTable = new DataTable();
            SQLiteCommand _Command = new SQLiteCommand("SELECT * FROM " + _TableName, AppliedConnection());
            SQLiteDataAdapter _Adapter = new SQLiteDataAdapter(_Command);
            DataSet _DataSet = new DataSet();
            try
            {
                _Adapter.Fill(_DataSet, _TableName);
                _DataTable = _DataSet.Tables[_TableName];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                _DataTable = new DataTable();
            }
            return _DataTable;
        }

        public static DataTable GetDataTable(string _TableName, string _Filter)
        {
            DataTable _DataTable = new DataTable();
            SQLiteCommand _Command = new SQLiteCommand("SELECT * FROM " + _TableName + " WHERE " + _Filter, AppliedConnection());
            SQLiteDataAdapter _Adapter = new SQLiteDataAdapter(_Command);
            DataSet _DataSet = new DataSet();
            try
            {
                _Adapter.Fill(_DataSet, _TableName);
                _DataTable = _DataSet.Tables[_TableName];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                _DataTable = new DataTable();
            }
            return _DataTable;
        }

        #endregion

        #region Table Commands

        public static bool SaveIPAddress(string _IP)
        {
            if (_IP.Length == 0) { return false; }
            string _CommandText = "INSERT INTO IP_ADDRESS (IP) VALUES (@IP)";
            DataTable _DataTable = GetDataTable("IP_Address");
            DataView _DataView = _DataTable.AsDataView();
            _DataView.RowFilter = "IP='" + _IP + "'";
            if (_DataView.Count == 0)
            {
                SQLiteCommand _Command = new SQLiteCommand(_CommandText, AppliedConnection());
                _Command.Parameters.AddWithValue("@IP", _IP);
                _Command.ExecuteNonQuery();
                try
                {
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool SetNature(string _IP, int _Nature)
        {
            if (_IP.Length == 0) { return false; }
            if (_Nature == 0) { return false; }

            string _CommandText = "UPDATE IP_ADDRESS SET Nature = @Nature WHERE IP=@IP;";
            DataTable _DataTable = GetDataTable("IP_Address");
            DataView _DataView = _DataTable.AsDataView();
            _DataView.RowFilter = "IP='" + _IP + "'";
            if (_DataView.Count > 0)
            {
                SQLiteCommand _Command = new SQLiteCommand(_CommandText, AppliedConnection());
                _Command.Parameters.AddWithValue("@IP", _IP);
                _Command.Parameters.AddWithValue("@Nature", _Nature);
                _Command.ExecuteNonQuery();
                try
                {
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        public static bool UpdateEmails(MimeMessage _Message, string _User)
        {
            string _CommandText = "INSERT INTO Emails VALUES (@ID, @User, @Date, @EmailID, @From, @To, @BodyText, @HTMLText, @Subject, @Header, @Headers, @IP)";
            DataTable _DataTable = GetDataTable("Emails");
            SQLiteCommand _Command = new SQLiteCommand(_CommandText, AppliedConnection());
            _Command.Parameters.AddWithValue("@ID", MaxID(_DataTable));
            _Command.Parameters.AddWithValue("@User", _User);
            _Command.Parameters.AddWithValue("@Date", _Message.Date);
            _Command.Parameters.AddWithValue("@EmailID", _Message.MessageId);
            _Command.Parameters.AddWithValue("@From", _Message.From);
            _Command.Parameters.AddWithValue("@To", _Message.To);
            _Command.Parameters.AddWithValue("@BodyText", _Message.TextBody);
            _Command.Parameters.AddWithValue("@HTMLText", _Message.HtmlBody);
            _Command.Parameters.AddWithValue("@Subject", _Message.Subject);
            _Command.Parameters.AddWithValue("@Header", _Message.Headers[0]);
            _Command.Parameters.AddWithValue("@Headers", _Message.Headers.ToString());
            _Command.Parameters.AddWithValue("@IP", EmailsClass.GetMessageIP(_Message));

            try
            {
                _Command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Email is not valid to save.");
                return false;
            }
        }               // END Update Emails

        public static long MaxID(DataTable _DataTable)
        {
            long max = 0;
            if (_DataTable.Rows.Count > 0)
            {
                max =  long.Parse(_DataTable.Compute("MAX(ID)", "").ToString()) + 1;
            }
            else
            {
                max = 0;
            }
            return max;
        }


        public enum Nature
        {
            White = 1,
            Block = 2,
            Delete = 3
        }

        //===================================== END HERE
    }
}
