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
    public partial class EditOfferForm : Form 
    {
        private Global.Offer offer;
        Image[] _chosenImages = Array.Empty<Image>();
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
            if (_chosenImages.Length > 0)
                Global.SaveOfferImages(_chosenImages, offer.Id, true);
            this.Hide();
            new MyAccountForm().ShowDialog();
            this.Close();
        }

        private void btnAttach_Click(object sender, EventArgs e) 
        {
            _chosenImages = Global.ChooseOfferImages();
        }
    }
}
