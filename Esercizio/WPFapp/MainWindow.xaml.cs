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

namespace WPFapp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime thisDate = new DateTime(Convert.ToInt32(txtDay.Text), Convert.ToInt32(txtDay1.Text), Convert.ToInt32(txtDay2.Text));

                var birthDay = int.Parse(txtDay.Text);
                var birthMonth = int.Parse(txtDay1.Text);
                var birthYear = int.Parse(txtDay2.Text);

                BirthDay b = new BirthDay(birthDay, birthMonth, birthYear);
                try
                {
                    int anni = b.CalcolaAnni();
                    lblResult.Content = $"Hai {anni} anni ";
                }
                catch (Exception ex)
                {
                    lblResult.Content = ex.Message;
                }

                
            }
            catch 
            {
                lblResult.Content = "Data non corretta";
                txtDay.Text = "";
                txtDay1.Text = "";
                txtDay2.Text = "";
                

                txtDay.Focus();
            }

        }

    }
}
