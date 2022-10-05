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
    public partial class OfferBoughtDialog : Form {

        public readonly string? offerName;
        
        public OfferBoughtDialog() {
            InitializeComponent();
        }

        public OfferBoughtDialog(string offerName) {
            this.offerName = offerName;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) => Close();

        private void OfferBoughtDialog_Load(object sender, EventArgs e) {
            if (offerName is not null)
                lblInfo.Text = $"Pojazd z oferty {offerName}\nzostał przez ciebie zakupiony.\nNie będzie on więcej dostępny dla\ninnych użytkowników.";
        }
    }
}
