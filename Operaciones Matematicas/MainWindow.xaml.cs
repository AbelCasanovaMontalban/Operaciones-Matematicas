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

namespace Operaciones_Matematicas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool Suma = true;
        private bool Resta = false;
        private bool Multiplicacion = false;
        private bool Division = false;

        public MainWindow()
        {
            InitializeComponent();
            SumaRadioButton.IsChecked = true;
        }

        public void Calcular()
        {

            int operando1;
            int operando2;
            int resultado;

            if (Operando1TextBox.Text.Length>0)
            {
                operando1 = Convert.ToInt32(Operando1TextBox.Text);
            }
            else
            {
                operando1 = 0;
            }

            if (Operando2TextBox.Text.Length > 0)
            {
                operando2 = Convert.ToInt32(Operando2TextBox.Text);
            }
            else
            {
                operando2 = 0;
            }

            if (Suma)
            {
                resultado = operando1 + operando2;
                ResultadoTextBox.Text = resultado.ToString();
            }

            if (Resta)
            {
                resultado = operando1 - operando2;
                ResultadoTextBox.Text = resultado.ToString();
            }

            if (Multiplicacion)
            {
                resultado = operando1 * operando2;
                ResultadoTextBox.Text = resultado.ToString();
            }

            if (Division)
            {
                if (operando2 == 0)
                {
                    ResultadoTextBox.Text = "ERROR";
                }
                else
                {
                    resultado = operando1 / operando2;
                    ResultadoTextBox.Text = resultado.ToString();
                }
                
            }


        }


        private void OperandoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calcular();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Operando1TextBox.Text = "0";
            Operando2TextBox.Text = "0";
            Calcular();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Suma = true;
            Multiplicacion = false;
            Resta = false;
            Division = false;
            Calcular();
        }

        private void RestaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Suma = false;
            Multiplicacion = false;
            Resta = true;
            Division = false;
            Calcular();
        }

        private void MultiplicacionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Suma = false;
            Multiplicacion = true;
            Resta = false;
            Division = false;
            Calcular();
        }

        private void DivisionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Suma = false;
            Multiplicacion = false;
            Resta = false;
            Division = true;
            Calcular();
        }

    }
}
