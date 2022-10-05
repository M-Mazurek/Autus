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
    public partial class OfferForm : Form {
        private Global.Offer _offer;
        public OfferForm(int offerNumber) {
            InitializeComponent();
            _offer = Global.GetOffers()[offerNumber];
        }

        // sterowanie i ustawienie ""etykiet""
        private void OfferForm_Load(object sender, EventArgs e) {
            Text = $"Autus : {_offer.Title}"; // tytuł oferty
            lblTitle.Text = $"Oferta użytkownika: {_offer.Author}"; // użytkownik
            //lblPics.Text = $"Zdjęcia pojazdu: {offers[0].Id}"; // nazwa pojazdu
            lblCar.Text = $"Marka: {_offer.Brand}"; 
            lblFuel.Text = $"Rodzaj paliwa: {_offer.FuelType}"; 
            lblMileage.Text = $"Przebieg: {_offer.Mileage}"; 
            lblPrice.Text = $"Cena: {_offer.Price}"; 
            lblProd.Text = $"Rok produkcji: {_offer.ProdYear}";
            lblState.Text = $"Stan: {_offer.State}";
            lblType.Text = $"Typ samochodu: {_offer.BodyType}";
            lblDesc.Text = _offer.Desc; // opis
            // chyba wszystko
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
        private void btnBuy_Click(object sender, EventArgs e) {
            //delete from database

        }

        
    }
}
