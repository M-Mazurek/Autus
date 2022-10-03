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
    public partial class EditOfferForm : Form {
        public EditOfferForm() {
            InitializeComponent();
        }

        // sterowanie i ustawienie ""pól tekstowych""
        private void EditOfferForm_Load(object sender, EventArgs e) {
            txtName.Text = null; // nazwa oferty
            txtMileage.Text = null;
            txtPrice.Text = null;
            txtProd.Text = null;
            txtCar.Text = null;
            cbState.SelectedIndex = 0;
            cbFuel.SelectedIndex = 0;
            cbType.SelectedIndex = 0;
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
