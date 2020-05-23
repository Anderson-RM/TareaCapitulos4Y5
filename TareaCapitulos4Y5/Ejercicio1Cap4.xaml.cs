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
    /// Interaction logic for Ejercicio1Cap4.xaml
    /// </summary>
    public partial class Ejercicio1Cap4 : Window
    {
 
        public Ejercicio1Cap4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.Clear();
            int tabla = int.Parse(TextBox1.Text);//esto es para que cuando digitamos algo en el textbox nos lo convierta en entero
            int limite = int.Parse(TextBox2.Text);
            int resultado;

            for (int i=1; i<=limite; i++) 
            {
                resultado = tabla * i;
                ListBox1.Items.Add(tabla + "x" + i + "=" + resultado);
            }
            

        }
    }
}
