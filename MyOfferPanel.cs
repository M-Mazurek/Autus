using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autus
{
    public partial class MyOfferPanel : UserControl
    {
        public int OfferNumber { get; set; } = 0;
        public int OfferID { get; set; } = 0;
        public MyOfferPanel()
        {
            InitializeComponent();
        }
        public void SetOffer(string title, string description, float price) 
        {
            txtTitle.Text = title;
            txtDescription.Text = description;
            txtPrice.Text = price.ToString() + " zł";
            pic.ConvertToOfferImage(OfferID);
        }
    }
}
