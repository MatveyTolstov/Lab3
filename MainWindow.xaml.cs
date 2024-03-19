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
using Lab1Kokoro.NIGHTCLUBDataSetTableAdapters;

namespace Lab1Kokoro
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Clients_Button_Click(object sender, RoutedEventArgs e)
        {
            ClientsWindow clientsWindow = new ClientsWindow();
            clientsWindow.Show();
            Close();
        }

        private void Events_Buttons_Click(object sender, RoutedEventArgs e)
        {
            EventWindow eventsWindow = new EventWindow();
            eventsWindow.Show();
            Close();
        }

        private void TableBooking_Buttons_Click(object sender, RoutedEventArgs e)
        {
            TableBooking table =  new TableBooking();
            table.Show();
            Close();
        }

        private void Full_Imfo_Click(object sender, RoutedEventArgs e)
        {
            FullInfo fullInfo = new FullInfo();
            fullInfo.Show();
            Close();
        }

        private void EF_Imfo_Click(object sender, RoutedEventArgs e)
        {
            EFINfo eFINfo  = new EFINfo();
            eFINfo.Show();
            Close();
        }
    }
}
