﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autus {
    public partial class loginForm : Form {

        public loginForm() {
            InitializeComponent();
        }

        private void SignIn() 
        {
            Hide();
            new OffersForm().ShowDialog();
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            // sprawdzanie loginu, hasła, czy jest w bazie itp.

            if (String.IsNullOrEmpty(txtPassword.Text)) 
            {
                new LoginErrorDialog().ShowDialog();
                return;
            }

            if (Global.HasUser(txtLogin.Text))
            {
                if (!Global.SignIn(txtLogin.Text, txtPassword.Text)) 
                {
                    new LoginErrorDialog().ShowDialog(); 
                    return;
                }
                new LoginDialog().ShowDialog();
                SignIn();
            }
            else
            {
                if (new RegisterConfirm().ShowDialog() == DialogResult.Cancel)
                    return;
                Global.AddUser(txtLogin.Text, txtPassword.Text);
                new RegisterDialog().ShowDialog();
                SignIn();
            }
        }
    }
}
