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
    /// Логика взаимодействия для ClientsType2.xaml
    /// </summary>
    public partial class ClientsType2 : Window
    {
        NIGHTCLUBEntities3 baza = new NIGHTCLUBEntities3();
        public ClientsType2()
        {
            InitializeComponent();
            ClientData.ItemsSource = baza.CLIENTS.ToList();
            
        }

        private void Button_Create_Click(object sender, RoutedEventArgs e)
        {
            CLIENTS cLIENTS = new CLIENTS();
            cLIENTS.FIRSTNAME = Client_Box.Text;

            baza.CLIENTS.Add(cLIENTS);
            baza.SaveChanges();
            ClientData.ItemsSource = baza.CLIENTS.ToList();
        }

        private void Button_Update_Click(object sender, RoutedEventArgs e)
        {

            if (ClientData.SelectedItem != null)
            {
                var select = ClientData.SelectedItem as CLIENTS;

                Client_Box.Text = select.FIRSTNAME;

            }
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (ClientData.SelectedItem != null)
            {
                baza.CLIENTS.Remove(ClientData.SelectedItem as CLIENTS);
                baza.SaveChanges();
                ClientData.ItemsSource = baza.CLIENTS.ToList();
            }
        }
    }
}
