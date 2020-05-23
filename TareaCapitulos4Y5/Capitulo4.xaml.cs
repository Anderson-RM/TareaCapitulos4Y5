using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TareaCapitulos4Y5
{
    /// <summary>
    /// Interaction logic for Capitulo4.xaml
    /// </summary>
    public partial class Capitulo4 : Window
    {
        public Capitulo4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)//ejercicio 1 del Cap4
        {
            Ejercicio1Cap4 Ej1C4 = new Ejercicio1Cap4();
            Ej1C4.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//ejercicio 2 del Cap4
        {
            Ejercicio2Cap4 Ej2C4 = new Ejercicio2Cap4();
            Ej2C4.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//ejercicio 5 del Cap4
        {
            Ejercicio5Cap4 Ej5C4 = new Ejercicio5Cap4();
            Ej5C4.Show();
        }
    }
}
