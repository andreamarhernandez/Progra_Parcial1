using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calimpuestos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Obtener el monto de la actividad económica del cuadro de texto.
            double monto = double.Parse(TextBox1.Text);

            // Calcular el impuesto.
            double impuesto = 0;

            // Recorrer la tabla de precios.
            for (int i = 0; i < Precios.Length; i++)
            {
                // Si el monto está dentro del rango de precios actual.
                if (monto >= Rangos[i] && monto < Rangos[i + 1])
                {
                    // Calcular el impuesto.
                    impuesto = Precios[i] + CostosAdicional[i] * (monto - Rangos[i]) / 1000;
                    break;
                }
            }

            // Mostrar el impuesto en el cuadro de texto.
            TextBox2.Text = impuesto.ToString("C2");
        }

        private static double[] Precios = new double[] { 1.5, 1.5, 3, 6, 9, 15, 39, 63, 93, 125, 195, 255 };
        private static double[] Rangos = new double[] { 0.01, 500.01, 1000.01, 2000.01, 3000.01, 8000.01, 18000, 01, 30000.01, 60000.01, 100000.01, 200000.01, 300000.01 };
        private static double[] CostosAdicional = new double[] { 0, 3, 3, 3, 2, 2, 2, 1, 0.8, 0.7, 0.6, 0.45 };

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
        