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
            if (String.IsNullOrWhiteSpace(txtName.Text) ||
                String.IsNullOrWhiteSpace(txtDesc.Text) ||
                !float.TryParse(txtPrice.Text, out float pr) ||
                !int.TryParse(txtProd.Text, out int prod) ||
                !float.TryParse(txtMileage.Text, out float mil) ||
                String.IsNullOrWhiteSpace(txtCar.Text))
            {
                new InputErrorDialog().ShowDialog();
                return;
            }

            if (new EditConfirm().ShowDialog() == DialogResult.Cancel)
                return;

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
            new OfferEditedDialog().ShowDialog();
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
