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
            double edad_1 = Convert.ToDouble(edad1.Text);
            double edad_2 = Convert.ToDouble(edad2.Text);
            double edad_3 = Convert.ToDouble(edad3.Text);
            double edad_4 = Convert.ToDouble(edad4.Text);
            double edad_5 = Convert.ToDouble(edad5.Text);
            double edad_6 = Convert.ToDouble(edad6.Text);

            double[] Todas = { edad_1, edad_2, edad_3, edad_4, edad_5, edad_6 };

            edadmin.Text = Convert.ToString(Todas.Min());
            edadmax.Text = Convert.ToString(Todas.Max());
            promedio.Text = Convert.ToString(Todas.Average());
             

            /**int edad_1 = int.Parse(edad1.Text);//esto es para que cuando digitamos algo en el textbox nos lo convierta en entero
            int edad_2 = int.Parse(edad2.Text);
            int edad_3 = int.Parse(edad3.Text);
            int edad_4 = int.Parse(edad4.Text);
            int edad_5 = int.Parse(edad55.Text);
            int edad_6 = int.Parse(edad6.Text);
            double promedio;
            bool edadmax, edadmin;

            /*int edad_1, edad_2, edad_3, edad_4, edad_5, edad_6;
            double promedio;
            ///string condicion;

            edad_1 = int.Parse(edad1.Text);
            edad_2 = int.Parse(edad2.Text);
            edad_3 = int.Parse(edad3.Text);
            edad_4 = int.Parse(edad4.Text);
            edad_5 = int.Parse(edad5.Text);
            edad_6 = int.Parse(edad6.Text);
            
            promedio = (edad_1 + edad_2 + edad_3 + edad_4 + edad_5 + edad_6) / 6;
            edadmax = (edad_1 + edad_2 + edad_3 + edad_4 + edad_5 + edad_6) > 6;
            edadmin = (edad_1 + edad_2 + edad_3 + edad_4 + edad_5 + edad_6) < 6;*/
        }
 
    }
}
