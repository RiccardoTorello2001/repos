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

namespace Wpfguia
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

        private void btnSomma_Click(object sender, RoutedEventArgs e)
        {
            int numero1;
            int numero2;
            numero1 = Convert.ToInt32(txtnum1.Text);
            numero2 = Convert.ToInt32(txtnum2.Text);
            int somma = 0;
            somma = numero1 + numero2;
            lblrisultato.Content = somma;

        }
    }
}
