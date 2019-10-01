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

namespace Contenedores
{
    /// <summary>
    /// Lógica de interacción para Rejilla.xaml
    /// </summary>
    public partial class Rejilla : Window
    {
        Point puntoActual = new Point();
        public Rejilla()
        {
            InitializeComponent();
         
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {


            if (e.LeftButton == MouseButtonState.Pressed)
            {
                // MessageBox.Show(puntoActual+"");
                Line line = new Line();

                line.Stroke = SystemColors.WindowFrameBrush;
                line.X1 = puntoActual.X;
                line.Y1 = puntoActual.Y;
                line.X2 = e.GetPosition(this).X;
                line.Y2 = e.GetPosition(this).Y;

                puntoActual = e.GetPosition(this);

                lienzo.Children.Add(line);
            }
        }

        private void Lienzo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            puntoActual = e.GetPosition(this);
        }
    }
}
