using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ej1.modelos;

namespace Ej1
{
    public partial class Form1 : Form
    {
        GeneralAge ages = new GeneralAge(); 
        int index = 0;  
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddElement();
        }

        private void AddElement()
        {
            try
            {
                int age = Convert.ToInt32(tbAge.Text);
                ages.AddElement(age, index);
                index++;
                ShowAges();
                tbAge.Clear();
                tbAge.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowAges()
        {
            try
            {
                lbAges.Items.Clear();
                for (int i = 0; i < index; i++)
                {
                    lbAges.Items.Add(ages.GetElements()[(int)i]);   
                }
                int sum = ages.GetElements().Sum();
                double average = sum/index;
                lblAddition.Text = "Suma: " + sum;
                lblAverage.Text = "Promedio: " + average;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                AddElement();
            }
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {

        }
    }
}
