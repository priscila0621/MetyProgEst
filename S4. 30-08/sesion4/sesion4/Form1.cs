using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sesion4.clases;

namespace sesion4
{
    public partial class Form1 : Form
    {
        Empleado myEmpleado = new Empleado();
        RRHH myRRHH = new RRHH();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            tbAumentar.Text = myRRHH.AumentarSalario(myEmpleado.Salary, myRRHH.Techo, myRRHH.Porcentaje).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbApellido.Clear();
            tbID.Clear();
            tbEmail.Clear();
            tbNumero.Clear();
            tbSalario.Clear();
            tbAumentar.Clear();
            tbTecho.Clear();
            nud.Value = 0;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            myEmpleado.FirstName = tbNombre.Text;
            myEmpleado.LastName = tbApellido.Text;
            myEmpleado.ID = tbID.Text;
            myEmpleado.Email = tbEmail.Text;
            myEmpleado.Phone = tbNumero.Text;
            myEmpleado.Salary = Convert.ToDouble(tbSalario.Text);
            myRRHH.Techo = Convert.ToDouble(tbTecho.Text);
            myRRHH.Porcentaje = ((double)nud.Value);
            MessageBox.Show("El registro ha sido guardado correctamente");
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
