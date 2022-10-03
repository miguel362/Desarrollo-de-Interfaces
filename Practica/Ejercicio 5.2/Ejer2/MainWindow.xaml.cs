using MahApps.Metro.Controls;
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

namespace ejer2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private static int veces = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void boton_click(object sender,RoutedEventArgs e)
        {
            veces++;
            if (veces == 1)
            {
                texto.Content = "Has apretado el botón " + veces + " vez!";
            }
            else
            {
                texto.Content = "Has apretado el botón " + veces + " veces!";
            } 
        }
    }
}