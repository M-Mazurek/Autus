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
        private Global.Offer offer;
        public EditOfferForm(int offerNumber)
        {
            InitializeComponent();
            offer = Global.GetOffers()[offerNumber];
        }

        // sterowanie i ustawienie ""pól tekstowych""
        private void EditOfferForm_Load(object sender, EventArgs e) {
            txtName.Text = offer.Title; // nazwa oferty
            txtMileage.Text = offer.Mileage.ToString();
            txtPrice.Text = offer.Price.ToString();
            txtProd.Text = offer.ProdYear.ToString();
            txtCar.Text = offer.Brand;
            txtDesc.Text = offer.Desc;

            cbState.SelectedIndex = (int)Math.Log2((double)offer.State);
            cbFuel.SelectedIndex = (int)Math.Log2((double)offer.FuelType);
            cbType.SelectedIndex = (int)Math.Log2((double)offer.BodyType);

            List<Global.EnumTextPair> stateList = new();
            foreach (var val in Enum.GetValues(typeof(STATE)))
                stateList.Add(new Global.EnumTextPair((int)val, Global.Ts((STATE)val).ToString()!));

            cbState.DisplayMember = "Text";
            cbState.DataSource = stateList;

            List<Global.EnumTextPair> bodyList = new();
            foreach (var val in Enum.GetValues(typeof(BODY_TYPE)))
                bodyList.Add(new Global.EnumTextPair((int)val, Global.Tb((BODY_TYPE)val).ToString()!));

            cbType.DisplayMember = "Text";
            cbType.DataSource = bodyList;

            List<Global.EnumTextPair> fuelList = new();
            foreach (var val in Enum.GetValues(typeof(FUEL_TYPE)))
                fuelList.Add(new Global.EnumTextPair((int)val, Global.Tf((FUEL_TYPE)val).ToString()!));

            cbFuel.DisplayMember = "Text";
            cbFuel.DataSource = fuelList;
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
            //update database
            Global.EditOffer(offer.Id,
                            txtName.Text,
                            txtDesc.Text,
                            float.Parse(txtPrice.Text),
                            int.Parse(txtProd.Text),
                            float.Parse(txtMileage.Text),
                            txtCar.Text,
                            (STATE)Math.Pow(2, cbState.SelectedIndex),
                            (BODY_TYPE)Math.Pow(2, cbType.SelectedIndex),
                            (FUEL_TYPE)Math.Pow(2, cbFuel.SelectedIndex));
            new OfferEditedDialog().ShowDialog();
            this.Hide();
            new MyAccountForm().ShowDialog();
            this.Close();
        }

        private void btnAttach_Click(object sender, EventArgs e) {

        }
    }
}
