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
using Lab1Kokoro.NIGHTCLUBDataSetTableAdapters;

namespace Lab1Kokoro
{
    /// <summary>
    /// Логика взаимодействия для FullInfo.xaml
    /// </summary>
    public partial class FullInfo : Window
    {
        private TABLEBOOKINGTableAdapter tableBookingAdapter = new TABLEBOOKINGTableAdapter();
        public FullInfo()
        {
            InitializeComponent();

            Full_Info.ItemsSource = tableBookingAdapter.GetData();

            
            
            

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Full_Info.Columns[4].Visibility = Visibility.Collapsed;
            Full_Info.Columns[5].Visibility = Visibility.Collapsed;
            Full_Info.Columns[6].Visibility = Visibility.Collapsed;
        }

    }
}
