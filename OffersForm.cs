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
    public partial class OffersForm : Form {
        private const int PANEL_HEIGHT = 100;
        private Global.Offer[]? _offers;
        public OffersForm() {
            InitializeComponent();
        }
        private void LoadOffers() 
        {
            int OffersCount = 0;
            int OfferNumber = -1;
            foreach (var o in _offers!) 
            {
                OfferNumber++;
                if (o.Author == Global.User)
                    continue;

                MyOfferPanel OfferPanel = new()
                {
                    Height = PANEL_HEIGHT,
                    Location = new(5, 5 + (PANEL_HEIGHT + 5) * OffersCount),
                };
                OfferPanel.OfferNumber = OfferNumber;
                OfferPanel.SetOffer(o.Title, o.Desc, o.Price);

                foreach (Control c in OfferPanel.Controls)
                    c.Click += OpenOffer;

                offers.Controls.Add(OfferPanel);

                OffersCount++;
            }
        }
        private void OpenOffer(object? sender, EventArgs e)
        {
            Hide();
            //new MyOfferForm(((MyOfferPanel)sender!).OfferNumber).ShowDialog();
            new OfferForm((((Control)sender!).Parent as MyOfferPanel)!.OfferNumber).ShowDialog();
            Close();
        }
        private class KYS 
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }
        // sterowanie
        private void MainForm_Load(object sender, EventArgs e) {
            btnOffers.Enabled = false;

            priceMin.Minimum = (decimal)Global.GetDefaultPriceRange().Item1;
            priceMin.Maximum = (decimal)Global.GetDefaultPriceRange().Item2;
            priceMax.Minimum = (decimal)Global.GetDefaultPriceRange().Item1;
            priceMax.Maximum = (decimal)Global.GetDefaultPriceRange().Item2;
            priceMax.Value = (decimal)Global.GetDefaultPriceRange().Item2;

            ProdukcjaMin.Minimum = Global.GetDefaultProdYearRange().Item1;
            ProdukcjaMin.Maximum = Global.GetDefaultProdYearRange().Item2;
            ProdukcjaMax.Minimum = Global.GetDefaultProdYearRange().Item1;
            ProdukcjaMax.Maximum = Global.GetDefaultProdYearRange().Item2;
            ProdukcjaMax.Value = Global.GetDefaultProdYearRange().Item2;

            PrzebiegMin.Minimum = (decimal)Global.GetDefaultMileageRange().Item1;
            PrzebiegMin.Maximum = (decimal)Global.GetDefaultMileageRange().Item2;
            PrzebiegMax.Minimum = (decimal)Global.GetDefaultMileageRange().Item1;
            PrzebiegMax.Maximum = (decimal)Global.GetDefaultMileageRange().Item2;
            PrzebiegMax.Value = (decimal)Global.GetDefaultMileageRange().Item2;

            lbBrand.Items.Clear();
            Global.GetBrands().ToList().ForEach(x => lbBrand.Items.Add(x));

            List<KYS> kysList = new List<KYS>();
            foreach (var val in Enum.GetValues(typeof(STATE)))
                kysList.Add(new KYS() { Value = (int)val, Text = val.ToString()! });

            lbState.DisplayMember = "Text";
            lbState.DataSource = kysList;
            kysList.Clear();

            foreach (var val in Enum.GetValues(typeof(BODY_TYPE)))
                kysList.Add(new KYS() { Value = (int)val, Text = val.ToString()! });

            lbBody.DisplayMember = "Text";
            lbBody.DataSource = kysList;
            kysList.Clear();

            foreach (var val in Enum.GetValues(typeof(FUEL_TYPE)))
                kysList.Add(new KYS() { Value = (int)val, Text = val.ToString()! });

            lbFuel.DisplayMember = "Text";
            lbFuel.DataSource = kysList;

            _offers = Global.GetOffers();
            LoadOffers();
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
        private void btnChange_Click(object sender, EventArgs e) {
            List<string> brands = new List<string>();
            foreach (var selectedItem in lbBrand.SelectedItems)
                brands.Add(selectedItem.ToString()!);

            int bitState = 0;
            foreach (KYS selectedItem in lbState.SelectedItems) 
                bitState += selectedItem.Value;

            int bitBody = 0;
            foreach (KYS selectedItem in lbBody.SelectedItems)
                bitBody += selectedItem.Value;

            int bitFuel = 0;
            foreach (KYS selectedItem in lbFuel.SelectedItems)
                bitFuel += selectedItem.Value;

            //((KYS)lbState.SelectedItem).Value;

            _offers = Global.GetOffers(((float)priceMin.Value, (float)priceMax.Value),
                                        ((int)ProdukcjaMin.Value, (int)ProdukcjaMax.Value),
                                        ((float)PrzebiegMin.Value, (float)PrzebiegMax.Value),
                                        brands.ToArray(),
                                        bitState,
                                        bitBody,
                                        bitFuel); //custom search
            offers.Controls.Clear();
            LoadOffers();
        }
    }
}
