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
    public partial class LoginErrorDialog : Form {
        public LoginErrorDialog() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) => Close();
    }
}
