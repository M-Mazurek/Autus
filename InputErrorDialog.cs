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
    public partial class InputErrorDialog : Form {
        public InputErrorDialog() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) => Close();
    }
}