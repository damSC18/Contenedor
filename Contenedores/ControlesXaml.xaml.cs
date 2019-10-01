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

using Newtonsoft.Json;
using System.IO;
namespace Contenedores
{
    /// <summary>
    /// Lógica de interacción para ControlesXaml.xaml
    /// </summary>
    public partial class ControlesXaml : Window
    {
        TreeViewItem elementoBuscado = new TreeViewItem();
        List<Apuntes> listaApuntes = new List<Apuntes>();
        private int i = 0;
        public ControlesXaml()
        {
            InitializeComponent();

            string json = File.ReadAllText("I:\\Curso 19_20\\DI_DAM\\UT1\\Ejercicios\\Contenedores\\Contenedores\\apuntes.json");
            //  MessageBox.Show(json);

            listaApuntes = JsonConvert.DeserializeObject<List<Apuntes>>(json);
             MessageBox.Show(listaApuntes[0].Modulo);

            int IndiceArray = 0;
            Apuntes registro = (Apuntes)listaApuntes.ElementAt(IndiceArray);
           // RegistroApuntes.ItemsSource = listaApuntes;
        }

        private void BotonRepeticion(object sender, RoutedEventArgs e)
        {
            i++;
            Mensajes.Content = Mensajes.Content.ToString() + i;
        }

        private void BotonNormal(object sender, RoutedEventArgs e)
        {
            Mensajes.Content = "Mensajes ";
        }


      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
  RegistroApuntes.ItemsSource = listaApuntes;
        }

        private void AñadirEmpleado(object sender, RoutedEventArgs e)
        {
            var item = new TreeViewItem();
            item.Header = cajaEmpleado.Text;
            listaEmpleados.Items.Add(item);

            
            var subItem = new TreeViewItem();
            subItem.Header = "Valladolid";
            item.Items.Add(subItem);
            var subItem1 = new TreeViewItem();
            subItem1.Header = "Peñafiel";
            item.Items.Add(subItem1);
            var subItem2 = new TreeViewItem();
            subItem2.Header = "98345";
            item.Items.Add(subItem2);

            // Añadir Elemento A un NodoArbol Seleccionado
            var itemSelecionado = new TreeViewItem();
            itemSelecionado =(TreeViewItem)listaEmpleados.Items.GetItemAt(0);
            var rayas = new TreeViewItem();
            rayas.Header = "------------------";
            itemSelecionado.Items.Add(rayas);
            var subItem3 = new TreeViewItem();
            subItem3.Header = "Soria";
            itemSelecionado.Items.Add(subItem3);
            var subItem4 = new TreeViewItem();
            subItem4.Header = "Almazan";
            itemSelecionado.Items.Add(subItem4);
            var subItem5 = new TreeViewItem();
            subItem5.Header = "92345";
            itemSelecionado.Items.Add(subItem5);

            // Buscar un Nodo por su contenido Epifanio Peludo
            string nodoBusqueda = "Epifanio Peludo";
            foreach (TreeViewItem elemento in listaEmpleados.Items)
            {
                if (elemento.Header.ToString() == nodoBusqueda)
                {
                    elemento.IsSelected = true;
                    elemento.Background = Brushes.Red;
                    elemento.Foreground = Brushes.Cyan;
                    elementoBuscado = elemento;
                    break;
                }
                
            }
        
    
    }

        private void BorraElementoSeleccionado(object sender, RoutedEventArgs e)
        {
            listaEmpleados.Items.Remove(elementoBuscado);
        }
    }
}
