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
    public partial class MyAccountForm : Form {
        private const int PANEL_HEIGHT = 100;
        public MyAccountForm() {
            InitializeComponent();
        }
        // sterowanie
        private void MyAccount_Load(object sender, EventArgs e) {
            btnAccount.Enabled = false;

            offers.HorizontalScroll.Maximum = 0;
            offers.AutoScroll = false;
            offers.VerticalScroll.Visible = false;
            offers.AutoScroll = true;

            Global.Offer[] _offers = Global.GetOffers();
            int MyOffersCount = 0;
            int OffersCount = 0;
            foreach (var off in _offers)
            {
                if (off.Author == Global.User) 
                {
                    MyOfferPanel OfferPanel = new()
                    {
                        Height = PANEL_HEIGHT,
                        Location = new(5, 5 + (PANEL_HEIGHT + 5) * MyOffersCount),
                        OfferNumber = OffersCount,
                        OfferID = off.Id,
                    };
                    OfferPanel.SetOffer(off.Title, off.Desc, off.Price);

                    foreach(Control c in OfferPanel.Controls)
                        c.Click += EditOffer;

                    offers.Controls.Add(OfferPanel);
                    MyOffersCount++;
                }
                OffersCount++;
            }
            txtOffersCount.Text += " " + MyOffersCount.ToString();
            //Global.AddOffer("test", "test", 500, 2000, 50000, "test", STATE.NEW, BODY_TYPE.SUV, FUEL_TYPE.DIESEL);
        }
        private void EditOffer(object? sender, EventArgs e)
        {
            Hide();
            //new MyOfferForm(((MyOfferPanel)sender!).OfferNumber).ShowDialog();
            new MyOfferForm((((Control)sender!).Parent as MyOfferPanel)!.OfferNumber).ShowDialog();
            Close();
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

        // reszta
        private void btnAccount_Click(object sender, EventArgs e) {

        }

    }
}
