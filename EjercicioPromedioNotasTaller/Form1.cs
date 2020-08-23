using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPromedioNotasTaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, suma, resultado;
            nota1 = double.Parse(txtnota1.Text);
            nota2 = double.Parse(txtnota2.Text);
            nota3 = double.Parse(txtnota3.Text);
            suma = nota1 + nota2 + nota3;
            resultado = suma /3;
            lblresultado.Text = Convert.ToString(resultado);
            label5.Visible = true;
            lblresultado.Visible = true;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtnota1.Text = String.Empty;
            txtnota2.Text = String.Empty;
            txtnota3.Text = String.Empty;
            txtnota1.Focus();
            label5.Visible = false;
            lblresultado.Visible = false;
        }
    }
}
