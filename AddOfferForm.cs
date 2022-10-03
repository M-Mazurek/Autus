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
    public partial class AddOfferForm : Form {
        public AddOfferForm() {
            InitializeComponent();
        }

        // sterowanie
        private void AddOfferForm_Load(object sender, EventArgs e) { 
            btnAddOffer.Enabled = false;
        }

        private void btnOffers_Click(object sender, EventArgs e) {
            this.Hide();
            new OffersForm().ShowDialog();
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e) {
            this.Hide();
            new MyAccountForm().ShowDialog();
            this.Close();
        }

        // reszta
        private void btnConfirm_Click(object sender, EventArgs e) {

        }

        private void btnAttach_Click(object sender, EventArgs e) {

        }

    }
}
