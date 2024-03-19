using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для ClientsWindow.xaml
    /// </summary>
    public partial class ClientsWindow : Window
    {
        CLIENTSTableAdapter clinet = new CLIENTSTableAdapter();
        public ClientsWindow()
        {
            InitializeComponent();
            ClientData.ItemsSource = clinet.GetData();
            ClientBoxName.ItemsSource = clinet.GetData();
            ClientBoxName.DisplayMemberPath = "FIRSTNAME";
            
        }


        private void ClientBoxName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Object clientname = (ClientBoxName.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(clientname.ToString());

        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }


        private void Button_Create_Click(object sender, RoutedEventArgs e)
        {
            clinet.InsertQuery(Clients_TextBox.Text);
            ClientData.ItemsSource = clinet.GetData();
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            object id = (ClientData.SelectedItem as DataRowView).Row[0];
            clinet.DeleteQuery(Convert.ToInt32(id));
            ClientData.ItemsSource = clinet.GetData();
        }

        private void Button_Update_Click(object sender, RoutedEventArgs e)
        {
            object id = (ClientData.SelectedItem as DataRowView).Row[0];
            clinet.UpdateQuery(Clients_TextBox.Text, Convert.ToInt32(id));
            ClientData.ItemsSource = clinet.GetData();
        }

        private void Next_Type_Click(object sender, RoutedEventArgs e)
        {
            ClientsType2 clientsType2 = new ClientsType2();
            clientsType2.Show();
            Close();
        }
    }
}
