﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FJ25_T2ProyectoColaborativo
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YA LLEGRON LAS PIPSHAS", "MARIELUQUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
