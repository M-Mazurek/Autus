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
    public partial class OffersForm : Form {
        public OffersForm() {
            InitializeComponent();
        }

        // sterowanie
        private void MainForm_Load(object sender, EventArgs e) {
            btnOffers.Enabled = false;
        }

        private void btnAddOffer_Click(object sender, EventArgs e) {
            this.Hide();
            new AddOfferForm().ShowDialog();
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e) {
            this.Hide();
            new MyAccountForm().ShowDialog();
            this.Close();
        }

        // reszta
        private void btnChange_Click(object sender, EventArgs e) {

        }
    }
}
