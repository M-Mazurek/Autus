using Microsoft.Data.SqlClient;

namespace Autus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Global.AddOffer("Test", "Hmm", 999, 1988, 0, "Fiat", Global.STATE.NEW, Global.BODY_TYPE.SUV, Global.FUEL_TYPE.PETROL);
            //Global.AddOffer("Test2", "Hmm", 10250, 2003, 100987, "Audi", Global.STATE.USED, Global.BODY_TYPE.SEDAN, Global.FUEL_TYPE.DIESEL);
            //Global.AddUser("pog", "hmm");

            textBox1.Text = Global.GetDefaultPriceRange().ToString();
            textBox2.Text = Global.GetDefaultProdYearRange().ToString();
            textBox3.Text = Global.GetDefaultMileageRange().ToString();
            textBox4.Text = String.Join(' ', Global.GetBrands());
            textBox5.Text = Convert.ToString(Global.GetDefaultStateFilter(), 2);
            textBox6.Text = Convert.ToString(Global.GetDefaultBodyTypeFilter(), 2);
            textBox7.Text = Convert.ToString(Global.GetDefaultFuelTypeFilter(), 2);

            textBox8.Text = String.Join(Environment.NewLine + Environment.NewLine, Global.GetOffers().Select(x => x.ToString()));
        }
    }
}