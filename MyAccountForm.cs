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
    public partial class MyAccountForm : Form {
        public MyAccountForm() {
            InitializeComponent();
        }
        // sterowanie
        private void MyAccount_Load(object sender, EventArgs e) {
            btnAccount.Enabled = false;
        }

        private void btnOffers_Click(object sender, EventArgs e) {
            this.Hide();
            new OffersForm().ShowDialog();
            this.Close();
        }

        private void btnAddOffer_Click(object sender, EventArgs e) {
            this.Hide();
            new AddOfferForm().ShowDialog();
            this.Close();
        }

        // reszta
        private void btnAccount_Click(object sender, EventArgs e) {

        }

    }
}
