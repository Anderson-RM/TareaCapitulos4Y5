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
    /// Interaction logic for Ejercicio5Cap4.xaml
    /// </summary>
    public partial class Ejercicio5Cap4 : Window
    {
        public Ejercicio5Cap4()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            int edad_1, edad_2, edad_3, edad_4, edad_5, edad_6;
            double promedio;
            string condicion;

            edad_1 = int.Parse(edad1.Text);
            edad_2 = int.Parse(edad2.Text);
            edad_3 = int.Parse(edad3.Text);
            edad_4 = int.Parse(edad4.Text);
            edad_5 = int.Parse(edad5.Text);
            edad_6 = int.Parse(edad6.Text);

            promedio = (edad_1 + edad_2 + edad_3 + edad_4 + edad_5 + edad_6) / 6;

        }
    }
}
