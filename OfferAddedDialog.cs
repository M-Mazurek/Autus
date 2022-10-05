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
    public partial class OfferAddedDialog : Form {

        private readonly string? offerName;

        public OfferAddedDialog() {
            InitializeComponent();
        }

        public OfferAddedDialog(string offerName) {
            this.offerName = offerName;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            Close();
        }

        private void OfferAddedDialog_Load(object sender, EventArgs e) {
            if (this.offerName is not null) // idk, jak działa ten nowy null-checking
                lblInfo.Text = $"Pomyślnie dodano ofertę\n{this.offerName},\nod teraz będzie ona widoczna\n dla innych użytkowników.";
        }
    }
}
