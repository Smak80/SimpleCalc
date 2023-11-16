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

namespace SimpleCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            double num1;
            if (!double.TryParse(Operand1.Text, out num1)) num1 = 0.0;
            double num2;
            if (!double.TryParse(Operand2.Text, out num2)) num2 = 0.0;

            try
            {
                LblResult.Text = (Operator.SelectedIndex switch
                {
                    0 => num1 + num2,
                    1 => num1 - num2,
                    2 => num1 * num2,
                    3 => num1 / num2,

                    _ => throw (new Exception("Выберите действие"))
                }).ToString();
            }

            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Внимание!!!!!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
