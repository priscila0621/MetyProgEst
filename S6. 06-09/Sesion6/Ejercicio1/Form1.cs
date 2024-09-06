﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarNombre()
        {
            string nombre = tbNombre.Text;
            cmbNombres.Items.Add(nombre);
            tbNombre.Text = " ";
            tbNombre.Focus();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            Agregar();
        }
        public void Agregar()
        {
            string nombre = tbNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("No puede quedar vacio el nombre");
                tbNombre.Focus();
                return;
            }
            cmbNombres.Items.Add(nombre);
            tbNombre.Text = " ";
            tbNombre.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            int cant = cmbNombres.Items.Count;
            for (int i = 0; i < cant; i++)
            {
                {
                    string nombre = cmbNombres.Items[i].ToString();
                    cmbNombres2.Items.Add(nombre);
                }
            }
        }
    }
}