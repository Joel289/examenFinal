using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Examen_Solis_Angel
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int num9=9;
        public int num8=8;
        public int num7=7;
        public int num6=6;
        public int num5=5;
        public int num4=4;
        public int num3=3;
        public int num2=2;
        public int num1=1;
        public int num0=0;
        public int val1 = 0;
        public int val2 = 0;
        int contdiv = 0;
        int contsum = 0;
        int contres = 0;
        int contmult = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + num7.ToString();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + num8.ToString();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + num9.ToString();
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {

            val1 = Int32.Parse(txtPantalla.Text);
            contdiv = contdiv + 1;
            txtPantalla.Text = "";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + num4.ToString();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + num5.ToString();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + num6.ToString();
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            val1 = Int32.Parse(txtPantalla.Text);
            contmult = contmult + 1;
            txtPantalla.Text = "";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + num1.ToString();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + num2.ToString();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + num3.ToString();
        }

        private void btnrest_Click(object sender, RoutedEventArgs e)
        {
            val1 = Int32.Parse(txtPantalla.Text);
            contres = contres + 1;
            txtPantalla.Text = "";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + num0.ToString();

        }

        private void btnpunto_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnigual_Click(object sender, RoutedEventArgs e)
        {
            val2 =  Int32.Parse(txtPantalla.Text);
            txtPantalla.Text = "";
            if (contsum>=1)
            {
                int resultado = val1 + val2;
                txtPantalla.Text = resultado.ToString();
                contsum = 0;
            }
            else
            {
                if (contres >= 1)
                {
                    int resultado = val1 - val2;
                    txtPantalla.Text = resultado.ToString();
                    contres = 0;
                }
                else
                {

                    if (contmult >= 1)
                    {
                        int resultado = val1 * val2;
                        txtPantalla.Text = resultado.ToString();
                        contmult = 0;
                    }
                    else
                    {
                        if (contdiv >= 1)
                        {
                            int resultado = val1 / val2;
                            txtPantalla.Text = resultado.ToString();
                            contdiv = 0;
                        }
                    }
                }
            }
        }

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            val1 = Int32.Parse(txtPantalla.Text);
            contsum = contsum + 1;
            txtPantalla.Text = "";
        }
    }
}
