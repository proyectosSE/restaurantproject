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
    public partial class mantdepar : Form
    {
        public mantdepar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string datos = "'"+txtdepart.Text+"',"+txtprovincia.Text+"";
            string tabla = "departamentos";
            cls.Agregar(datos, tabla);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
