﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iShelter
{
    public partial class iShelter : Form
    {
        public iShelter()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Visible = false;
            menu.ShowDialog();
        }
    }
}
