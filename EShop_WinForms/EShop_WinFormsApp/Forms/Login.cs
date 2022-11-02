using MAS_WinFormsApp.DTO;
using MAS_WinFormsApp.Helpers;
using MAS_WinFormsApp.Models.Persons.Customers;
using MAS_WinFormsApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAS_WinFormsApp.Forms
{
    public partial class Login : Form
    {
        private EShopDBRepository _database;

        public Login()
        {
            InitializeComponent();
        }
        public Login(EShopDBRepository database) : this()
        {
            if (database == null) throw new Exception("[Error]: Database can not be null");

            _database = database;
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextbox.Text;
            string password = passwordTextbox.Text;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    $"Email and password are required.",
                    "Email or password is empty",
                    MessageBoxButtons.OK);
                return;
            }
            var customer = _database.GetCustomer(email, password);
            if (customer == null)
            {
                MessageBox.Show(
                    "Incorrect email or password.",
                    "Wrong operation",
                    MessageBoxButtons.OK);
                return;
            }

            this.FormClosing -= Login_FormClosing;
            FormsController.SwitchWindowFormWithClose(new Menu(_database, customer));
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                    "Do you really want to exit?",
                    "Exit confirmation",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) Environment.Exit(0);
                else e.Cancel = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            passwordTextbox.PasswordChar = '*';
        }
    }
}
