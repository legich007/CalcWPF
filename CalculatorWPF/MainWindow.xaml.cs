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
using Calculator;

namespace CalculatorWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";
        private const int DEFAULT_WIDTH = 355;
        private const int DEFAULT_HEIGHT = 350;


        public MainWindow()
        {
            InitializeComponent();
            ClassicTool.IsEnabled = false;
            EngeneerTool.IsEnabled = true;
            this.Width = DEFAULT_WIDTH;
            this.Height = DEFAULT_HEIGHT;
        }



        private void KeyExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(zeroOut);
        }

        private void KeyOne_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(oneOut);
        }

        private void KeyTwo_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(twoOut);
        }

        private void KeyThree_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(threeOut);
        }

        private void KeyFour_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fourOut);
        }

        private void KeyFive_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fiveOut);
        }

        private void KeySix_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sixOut);
        }

        private void KeySeven_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sevenOut);
        }

        private void KeyEight_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(eightOut);
        }

        private void KeyNine_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(nineOut);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcDecimal();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSign();
        }

        private void KeyDivide_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
        }

        private void KeyMultiply_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
        }

        private void KeyMinus_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);
        }

        private void KeyPlus_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eAdd);
        }

        private void KeyEqual_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcSpecialReset();

        }

        private void KeyClear_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcReset();
            OutputDisplay.Text = "0";
        }

        private void KeyDate_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.GetDate();
            CalcEngine.CalcReset();
        }

        private void EngeneerTool_Click(object sender, RoutedEventArgs e)
        {
            this.Width = 500;
            ClassicTool.IsEnabled = true;
            EngeneerTool.IsEnabled = false;
        }

        private void ClassicTool_Click(object sender, RoutedEventArgs e)
        {
            ClassicTool.IsEnabled = false;
            EngeneerTool.IsEnabled = true;
            this.Width = DEFAULT_WIDTH;
            this.Height = DEFAULT_HEIGHT;
        }

        private void KeyDegree_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDegree);
        }

        private void KeySQRT_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSQRT);
            OutputDisplay.Text = CalcEngine.CalcEqual();
           // CalcEngine.CalcReset();
        }

        private void KeyReverse_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDivByOne);
            OutputDisplay.Text = CalcEngine.CalcEqual();
           // CalcEngine.CalcReset();
        }

        private void KeyDegree2_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDegree2);
            OutputDisplay.Text = CalcEngine.CalcEqual();
           // CalcEngine.CalcReset();
        }

        private void KeyFactorial_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eFactorial);
            OutputDisplay.Text = CalcEngine.CalcEqual();
           // CalcEngine.CalcReset();
        }

        private void KeyCBRT_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eCBRT);
            OutputDisplay.Text = CalcEngine.CalcEqual();
           // CalcEngine.CalcReset();
        }

        private void KeyQE_Click(object sender, RoutedEventArgs e)
        {
            QEWindow formQE = new QEWindow();
            formQE.Owner = this;
            formQE.Show();
        }
    }
}
