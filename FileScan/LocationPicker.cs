﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileScan
{
    public partial class LocationPicker : Form
    {
        public LocationPicker()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool accepted = false;
        private void btnOk_Click(object sender, EventArgs e)
        {
            accepted = true;
            this.Close();
        }
    }
}
