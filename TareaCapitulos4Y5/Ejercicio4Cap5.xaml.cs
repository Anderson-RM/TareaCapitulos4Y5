﻿using System;
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
    /// Interaction logic for Ejercicio4Cap5.xaml
    /// </summary>
    public partial class Ejercicio4Cap5 : Window
    {
        public Ejercicio4Cap5()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            int n;             
                int i = 2;
                double factorial = 1;
                n = int.Parse(numero.Text);

                while(i <= n)
                {
                    factorial *= i;
                    i++;
                }
                resultado.Text = Convert.ToString(factorial);
                ///return factorial;
            
        }
 
    }
}
