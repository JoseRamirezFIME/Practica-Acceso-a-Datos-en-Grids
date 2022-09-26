﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTestBD
{
    public partial class Form1 : Form
    {
        string consulta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string consulta;
                consulta = Microsoft.VisualBasic.Interaction.InputBox("Ingresa La cunsulta");
            int registros = 0;
                Conexion.EjecutaConsulta(consulta);
                AccionesComunes.Mensaje("" + registros);
            }
        

        private void button2_Click(object sender, EventArgs e)
        {
            consulta = AccionesComunes.CrearConsulta(txtAccion.Text, txtVariables.Text, txtTabla.Text);
            AccionesComunes.LlenarCombo(consulta, comboBox1, "id", "Nombres");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedValue .ToString();  
        }


        private void button3_Click(object sender, EventArgs e)
        {
           consulta = AccionesComunes.CrearConsulta(txtAccion.Text, txtVariables.Text, txtTabla.Text);
            AccionesComunes.LlenarDataGrid(consulta,dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            consulta = AccionesComunes.CrearConsulta(txtAccion.Text, txtVariables.Text, txtTabla.Text);
            AccionesComunes.LlenarListview(consulta, listView1);


        }
    }
}
