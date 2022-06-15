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

namespace wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Complex complex;
        private Vector3D vector;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //Модуль и норма комплексного часа
        {
            complex = new Complex(double.Parse(Aba.Text),
                double.Parse(Ba.Text));
            Result1.Text = complex.Print();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)//Модуль и норма вектора
        {
            vector = new Vector3D(double.Parse(X.Text), double.Parse(Y.Text));
            Result2.Text = vector.Print();
        }
    }
}
