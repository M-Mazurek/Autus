using System;
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

        private void btnLogin_Click(object sender, EventArgs e) {
            // sprawdzanie loginu, hasła, czy jest w bazie itp.
            if (true) {
                Hide();
                new OffersForm().ShowDialog();
                Close();
            } else { 
                // dialog
            }
        }
    }
}
