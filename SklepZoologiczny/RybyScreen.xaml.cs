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

namespace SklepZoologiczny
{
    /// <summary>
    /// Logika interakcji dla klasy RybyScreen.xaml
    /// </summary>
    public partial class RybyScreen : Window
    {
        public RybyScreen()
        {
            InitializeComponent();
        }

        private void zar_click(object sender, RoutedEventArgs e)
        {
            RegisterScreen dashboard = new RegisterScreen();
            dashboard.Show();
            Close();
        }

        private void zal_click(object sender, RoutedEventArgs e)
        {
            LoginScreen dashboard = new LoginScreen();
            dashboard.Show();
            Close();
        }

        private void psy_click(object sender, RoutedEventArgs e)
        {
            PsyScreen dashboard = new PsyScreen();
            dashboard.Show();
            Close();

        }

        private void koty_click(object sender, RoutedEventArgs e)
        {
            KotyScreen dashboard = new KotyScreen();
            dashboard.Show();
            Close();

        }

        private void male_click(object sender, RoutedEventArgs e)
        {
            MaleZwScreen dashboard = new MaleZwScreen();
            dashboard.Show();
            Close();

        }

        private void gady_click(object sender, RoutedEventArgs e)
        {
            PlazyGadyScreen dashboard = new PlazyGadyScreen();
            dashboard.Show();
            Close();

        }

        private void ryby_click(object sender, RoutedEventArgs e)
        {
            RybyScreen dashboard = new RybyScreen();
            dashboard.Show();
            Close();

        }

        private void akcesoria_click(object sender, RoutedEventArgs e)
        {
            AkcesoriaScreen dashboard = new AkcesoriaScreen();
            dashboard.Show();
            Close();

        }

    }
}
