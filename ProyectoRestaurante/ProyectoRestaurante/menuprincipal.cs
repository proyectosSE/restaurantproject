﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante
{
    public partial class menuprincipal : Form
    {
        public menuprincipal()
        {
            InitializeComponent();
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            mantcli mantenicli = new mantcli(); 
            mantenicli.Show();

        }
    }
}
