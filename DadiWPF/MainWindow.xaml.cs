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

namespace DadiWPF
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

        private void btn_Lan(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int numeroCasuale = random.Next(1, 6);
            string r=numeroCasuale.ToString();
            
            int numero = int.Parse(Input.Text);
            if (numero == numeroCasuale)
            {
                Output.Text =r +" Complimenti, hai vinto!";
            }
            else
            {
                Output.Text = r+" Ritenta, sarai più fortunato";
            }
            if(numero<1 || numero > 6)
            {
                MessageBox.Show("Inserisci un numero compreso tra 1 e 6","Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btn_Rico(object sender, RoutedEventArgs e)
        {
            Output.Clear();
            Input.Clear();
        }
        
    }
}
