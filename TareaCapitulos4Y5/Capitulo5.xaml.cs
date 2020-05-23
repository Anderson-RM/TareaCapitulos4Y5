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
    /// Interaction logic for Capitulo5.xaml
    /// </summary>
    public partial class Capitulo5 : Window
    {
        public Capitulo5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)//ejercicio 4 del Cap5
        {
            Ejercicio4Cap5 Ej4C5 = new Ejercicio4Cap5();
            Ej4C5.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//ejercicio 5 del Cap5
        {
            Ejercicio5Cap5 Ej5C5 = new Ejercicio5Cap5();
            Ej5C5.Show();
        }
    }
}
