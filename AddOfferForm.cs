﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autus {
    public partial class AddOfferForm : Form 
    {
        Image[] _chosenImages = Array.Empty<Image>();
        public AddOfferForm()
        {
            InitializeComponent();
        }

        // sterowanie
        private void AddOfferForm_Load(object sender, EventArgs e) { 
            btnAddOffer.Enabled = false;

            List<Global.EnumTextPair> stateList = new();
            foreach (var val in Enum.GetValues(typeof(STATE)))
                stateList.Add(new Global.EnumTextPair((int)val, Global.Ts((STATE)val).ToString()!));

            cbState.DisplayMember = "Text";
            cbState.DataSource = stateList;

            List<Global.EnumTextPair> bodyList = new();
            foreach (var val in Enum.GetValues(typeof(BODY_TYPE)))
                bodyList.Add(new Global.EnumTextPair((int)val, Global.Tb((BODY_TYPE)val).ToString()!));

            cbBody.DisplayMember = "Text";
            cbBody.DataSource = bodyList;

            List<Global.EnumTextPair> fuelList = new();
            foreach (var val in Enum.GetValues(typeof(FUEL_TYPE)))
                fuelList.Add(new Global.EnumTextPair((int)val, Global.Tf((FUEL_TYPE)val).ToString()!));

            cbFuel.DisplayMember = "Text";
            cbFuel.DataSource = fuelList;
        }

        private void btnOffers_Click(object sender, EventArgs e) {
            this.Hide();
            new OffersForm().ShowDialog();
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

            Global.AddOffer(txtName.Text,
                            txtDesc.Text,
                            float.Parse(txtPrice.Text),
                            int.Parse(txtProd.Text),
                            float.Parse(txtMileage.Text),
                            txtCar.Text,
                            (STATE)Math.Pow(2, cbState.SelectedIndex),
                            (BODY_TYPE)Math.Pow(2, cbBody.SelectedIndex),
                            (FUEL_TYPE)Math.Pow(2, cbFuel.SelectedIndex));
            Global.SaveOfferImages(_chosenImages, Global.GetLastID());
            new OfferAddedDialog().ShowDialog();
            Hide();
            new MyAccountForm().ShowDialog();
            Close();
        }

        private void btnAttach_Click(object sender, EventArgs e) {
            _chosenImages = Global.ChooseOfferImages();
        }

    }
}
