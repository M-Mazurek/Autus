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
        public AddOfferForm()
        {
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
            Global.AddOffer(txtName.Text,
                            txtDesc.Text,
                            float.Parse(txtPrice.Text),
                            int.Parse(txtProd.Text),
                            float.Parse(txtMileage.Text),
                            txtCar.Text,
                            (STATE)Math.Pow(2, cbState.SelectedIndex),
                            (BODY_TYPE)Math.Pow(2, cbBody.SelectedIndex),
                            (FUEL_TYPE)Math.Pow(2, cbFuel.SelectedIndex));
            this.Hide();
            new MyAccountForm().ShowDialog();
            this.Close();
        }

        private void btnAttach_Click(object sender, EventArgs e) {
            //idk
        }

    }
}
