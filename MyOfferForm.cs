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
    public partial class MyOfferForm : Form {
        private Global.Offer _offers;
        private int _offerNumber;
        public MyOfferForm(int offerNumber) {
            InitializeComponent();
            _offerNumber = offerNumber;
            _offers = Global.GetOffers()[offerNumber];
        }
        // sterowanie i ustawienie ""etykiet""
        private void MyOfferForm_Load(object sender, EventArgs e) {
            Text = $"Autus : {_offers.Title}"; // tytuł oferty
            //lblTitle.Text = $"Oferta użytkownika: {_offers.Author}"; // użytkownik
            //lblPics.Text = $"Zdjęcia pojazdu: {offers.Id}"; // nazwa pojazdu
            lblCar.Text = $"Marka: {_offers.Brand}";
            lblFuel.Text = $"Rodzaj paliwa: {_offers.FuelType}";
            lblMileage.Text = $"Przebieg: {_offers.Mileage}";
            lblPrice.Text = $"Cena: {_offers.Price}";
            lblProd.Text = $"Rok produkcji: {_offers.ProdYear}";
            lblState.Text = $"Stan: {_offers.State}";
            lblType.Text = $"Typ samochodu: {_offers.BodyType}";
            lblDesc.Text = _offers.Desc;
        }

        private void btnOffers_Click(object sender, EventArgs e) {
            this.Hide();
            new OffersForm().ShowDialog();
            this.Close();
        }

        private void btnAddOffer_Click(object sender, EventArgs e) {
            this.Hide();
            new EditOfferForm(_offerNumber).ShowDialog();
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e) {
            this.Hide();
            new MyAccountForm().ShowDialog();
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Remove from database
            this.Hide();
            new MyAccountForm().ShowDialog();
            this.Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            //Edit zla nazwa btn )
            Hide();
            new EditOfferForm(_offerNumber).ShowDialog();
            Close();
        }
    }
}
