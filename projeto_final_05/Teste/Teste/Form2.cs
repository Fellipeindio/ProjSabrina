﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bntVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 _form1 = new Form1();
            _form1.Show();

        }
    }
}
