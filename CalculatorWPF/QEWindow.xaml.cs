using SimpleCalculator;
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
using System.Windows.Shapes;


namespace CalculatorWPF
{
    /// <summary>
    /// Логика взаимодействия для QEWindow.xaml
    /// </summary>
    public partial class QEWindow : Window
    {
        public QEWindow()
        {
            InitializeComponent();
        }
        protected string a
        {
            get { return textBoxA.Text; }
            set { textBoxA.Text = value; }
        }

        protected string b
        {
            get { return textBoxB.Text; }
            set { textBoxB.Text = value; }
        }

        protected string c
        {
            get { return textBoxC.Text; }
            set { textBoxC.Text = value; }
        }

        

       

        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            double x1;
            double x2;

            try
            {
                double a1 = double.Parse(a);
                double b1 = double.Parse(b);
                double c1 = double.Parse(c);
                if (Ur.Deskr(a1, b1, c1) >= 0)
                {
                    Ur.Gg(a1, b1, c1, out x1, out x2);
                    richTextBox1.Text = $"{a}*x^2 + {b}*x + {c} = 0\n" + $"Корни уравнения: \nx1 = {x1}\nx2 = {x2} ";
                }
                else richTextBox1.Text = "Корней нет";
                //richTextBox1.
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");

            }


        }

        private void textBoxA_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            double val;
            if (!Double.TryParse(e.Text, out val) && e.Text != "-" && e.Text!=".")
            {
                e.Handled = true; // отклоняем ввод
            }
        }

        private void textBoxB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            double val;
            if (!Double.TryParse(e.Text, out val) && e.Text != "-" && e.Text != ".")
            {
                e.Handled = true; // отклоняем ввод
            }
        }

        private void textBoxC_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            double val;
            if (!Double.TryParse(e.Text, out val) && e.Text != "-" && e.Text != ".")
            {
                e.Handled = true; // отклоняем ввод
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            richTextBox1.Clear();
        }
    }
}
