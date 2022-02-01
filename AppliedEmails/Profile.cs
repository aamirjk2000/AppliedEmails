using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliedEmails
{
    public partial class frmProfile : Form
    {
        private RegistryKey Openkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AppliedEmails", true);
        string[] KeyValues = { "Server", "User", "Pward", "In-PortPop3", "In-PortIMAP" };

        public frmProfile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            UserProfile ProfileClass = new UserProfile();

            txtServer.Text = ProfileClass.Server;
            txtUser.Text = ProfileClass.User;
            txtPassword.Text = ProfileClass.Password;
            txtPortPop3.Text = ProfileClass.PortPop3;
            txtIPortIMAP.Text = ProfileClass.IPortIMAP;
                
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Openkey != null)
            {
                Openkey.SetValue(KeyValues[0], txtServer.Text.Trim());
                Openkey.SetValue(KeyValues[1], txtUser.Text.Trim());
                Openkey.SetValue(KeyValues[2], txtPassword.Text.Trim());
                Openkey.SetValue(KeyValues[3], txtPortPop3.Text.Trim());
                Openkey.SetValue(KeyValues[4], txtIPortIMAP.Text.Trim());
                MessageBox.Show("Values have been saved");
            }
            else
            {
                MessageBox.Show("Registry Key is not exist. Values not aved.");
            }
        }
    }
}


public class UserProfile
{
    private RegistryKey Createkey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AppliedEmails", true);
    private string[] KeyValues = { "Server", "User", "Pward", "In-PortPop3", "In-PortIMAP" };
    
    public string Server { get; set; }
    public string User { get; set; }
    public string Password { get; set; }
    public string PortPop3 { get; set; }
    public string IPortIMAP { get; set; }

    public UserProfile()
    {
        Server = (string)Createkey.GetValue(KeyValues[0]);
        User = (string)Createkey.GetValue(KeyValues[1]);
        Password = (string)Createkey.GetValue(KeyValues[2]);
        PortPop3 = (string)Createkey.GetValue(KeyValues[3]);
        IPortIMAP = (string)Createkey.GetValue(KeyValues[4]);
    }

}

