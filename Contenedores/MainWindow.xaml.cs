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

namespace Contenedores
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Boton_Click(object sender, RoutedEventArgs e)
        {
            Rejilla rr = new Rejilla();
            rr.Show();
           
        }

        private void DiseñoResponsive(object sender, RoutedEventArgs e)
        {
            responsive resp = new responsive();
            resp.Show();

        }

        private void Controles_Click(object sender, RoutedEventArgs e)
        {
            ControlesXaml cx = new ControlesXaml();
            cx.Show();
        }
    }
}
