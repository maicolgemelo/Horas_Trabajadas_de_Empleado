using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horas_Trabajadas_de_Empleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double HorasTrabajadas = double.Parse(txtHorasTrabajadas.Text);
            double valorHora = double.Parse(txtValorHora.Text);
            double total = HorasTrabajadas * valorHora;
            
            

            if (total < 700000)
            {
                MessageBox.Show("El empleado gana menos del minimo");
                lblTotalSalario.Text = total.ToString();
                lblTotalSalario.Visible = true;
                total = (total * 0.10) + total;
                lblTotalSalario.Text = " $ " + Convert.ToDecimal(total).ToString("N0");
                lblTotalSalario.Visible = true;
                MessageBox.Show("Se le hace un imcremento del 10% ");
            }
            else if(total <= 1000000)
            {
                
                MessageBox.Show("El empleado gana el o un poco mas del minimo ");
                lblTotalSalario.Text = total.ToString();
                lblTotalSalario.Visible = true;
                total = (total * 0.02) - total;
                lblTotalSalario.Text = " $ " + Convert.ToDecimal(total).ToString("N0");
                lblTotalSalario.Visible = true;
                MessageBox.Show("Se le hace un descuento del 2% ");
            }
            else if (total >= 1000001)
            {


                MessageBox.Show("El empleado gana mas del minimo ");
                lblTotalSalario.Text = total.ToString();
                lblTotalSalario.Visible = true;
                total = (total * 0.05) - total;
                total = (total * 0.02) + total;
                lblTotalSalario.Text = " $ " + Convert.ToDecimal(total).ToString("N0");               
                lblTotalSalario.Visible = true;
                MessageBox.Show("Se le hace un descuento del 5% y luego un incremento del 2%");



               
            }
           
            
         
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtHorasTrabajadas.Text = "";
            txtValorHora.Text = "";
            lblTotalSalario.Text = "";
        }
    }
}
