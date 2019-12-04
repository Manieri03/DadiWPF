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

        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Lan(object sender, RoutedEventArgs e)
        {
            int numeroCasuale = random.Next(1, 7);
            int puntata = int.Parse(txtpuntata.Text);
            int crediti = int.Parse(lblcrediti.Content.ToString());
            string r=numeroCasuale.ToString();

            int numero = int.Parse(Input.Text);
           
            if (puntata <= crediti)
            {
                if (numero < 1 || numero > 6)
                {
                    MessageBox.Show("Inserisci un numero compreso tra 1 e 6", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                if (numero == numeroCasuale)
                {
                    Output.Text = r + " Complimenti, hai vinto!";
                }
                else
                {
                    Output.Text = r + " Ritenta, sarai più fortunato";
                }
                Uri resourceUri = new Uri($"/Images/dado{r}.png", UriKind.Relative);
                dadoimage.Source = new BitmapImage(resourceUri);
                if (numeroCasuale== numero)
                {
                    crediti = crediti + puntata * 3;
                    lblcrediti.Content = crediti;
                }
                else
                {
                    crediti = crediti - puntata;
                    lblcrediti.Content = crediti;

                }
                if (crediti == 0)
                {
                    MessageBox.Show("GAME OVER, hai finito i crediti. Premi ricomincia", "GAME OVER", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Non puoi inserire una puntata maggiore dei tuoi crediti", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btn_Rico(object sender, RoutedEventArgs e)
        {
            Output.Clear();
            Input.Clear();
            lblcrediti.Content = 100;
            txtpuntata.Clear();
            dadoimage.Source = null;
        }

    }
}
