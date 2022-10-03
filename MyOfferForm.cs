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
        public MyOfferForm() {
            InitializeComponent();
        }
        // sterowanie i ustawienie ""etykiet""
        private void MyOfferForm_Load(object sender, EventArgs e) {
            Text = $"Autus : {null}"; // tytuł oferty
            lblTitle.Text = $"Oferta użytkownika: {null}"; // użytkownik
            lblPics.Text = $"Zdjęcia pojazdu: {null}"; // nazwa pojazdu
            lblCar.Text = $"Marka: {null}";
            lblFuel.Text = $"Rodzaj paliwa: {null}";
            lblMileage.Text = $"Przebieg: {null}";
            lblPrice.Text = $"Cena: {null}";
            lblProd.Text = $"Rok produkcji: {null}";
            lblState.Text = $"Stan: {null}";
            lblType.Text = $"Typ samochodu: {null}";
            lblDesc.Text = null; // opis
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
    }
}
