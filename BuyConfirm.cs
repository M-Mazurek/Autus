﻿using System;
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
    public partial class BuyConfirm : Form
    {
        public BuyConfirm()
        {
            InitializeComponent();
        }

        private void btnAnuluj_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

        private void btnOK_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;
    }
}
