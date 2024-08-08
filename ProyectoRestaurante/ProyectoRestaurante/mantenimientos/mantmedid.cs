﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRestaurante
{
    public partial class mantmedid : Form
    {
        public mantmedid()
        {
            InitializeComponent();
            buttEdit.Visible = false;
            cargardatos();
        }

        private string mivar;
        private void button1_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string datos = "'"+txtmedida.Text+"'";
            string tabla = "medidas";
            cls.Agregar(datos, tabla);
            cargardatos();
        }

        private void cargardatos()
        {
            String consulta = "SELECT * FROM medidas";
            
            try
            {
                using (SqlConnection conexion = new SqlConnection(rutadb.conexion))
                {
                    conexion.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;

                        // Configuración de columnas
                        if (dataGridView1.Columns.Contains("id_medida")) dataGridView1.Columns["id_medida"].DisplayIndex = 0;
                        if (dataGridView1.Columns.Contains("descripcion")) dataGridView1.Columns["descripcion"].DisplayIndex = 1;
                        if (dataGridView1.Columns.Contains("editar")) dataGridView1.Columns["editar"].DisplayIndex = 2;
                        if (dataGridView1.Columns.Contains("eliminar")) dataGridView1.Columns["eliminar"].DisplayIndex = 3;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }

        private void buttEdit_Click(object sender, EventArgs e)
        {
            Conectar cls = new Conectar();
            string up = "descripcion ='" + txtmedida.Text + "'";
            string tbl = "medidas";
            string id = "id_medida = '" + mivar + "'";
            cls.Actualizar(up, tbl, id);

            buttEdit.Visible = false;
            cargardatos();
            button1.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                txtmedida.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
                mivar = dataGridView1.CurrentRow.Cells["id_medida"].Value.ToString();
                buttEdit.Visible = true;
                button1.Visible = false;

            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                mensaje ms = new mensaje();

                if (ms.ShowDialog() == DialogResult.OK)
                {
                    mivar = dataGridView1.CurrentRow.Cells["id_medida"].Value.ToString();
                    Conectar cls = new Conectar();
                    string tbl = "medidas";
                    string id = "id_medida = '" + mivar + "'";
                    cls.eliminar(tbl, id);
                    cargardatos();
                }
            }
        }
    }
}
