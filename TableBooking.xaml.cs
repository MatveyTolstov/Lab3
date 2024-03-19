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
    /// Логика взаимодействия для TableBooking.xaml
    /// </summary>
    public partial class TableBooking : Window
    {
        TABLEBOOKINGTableAdapter table = new TABLEBOOKINGTableAdapter();
        public TableBooking()
        {
            InitializeComponent();
            TableData.ItemsSource = table.GetData();
            TableBoxName.ItemsSource = table.GetData();
            TableBoxName.DisplayMemberPath = "BOOKING_DATE"; 
        }

        private void TableBoxName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Object tablename = (TableBoxName.SelectedItem as DataRowView).Row[4];
            MessageBox.Show(tablename.ToString());
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Button_Create_Click(object sender, RoutedEventArgs e)
        {
            int numbers = Int32.Parse(Table_TextBox.Text);
            table.InsertQuery(numbers);
            TableData.ItemsSource = table.GetData();
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            object id = (TableData.SelectedItem as DataRowView).Row[0];
            table.DeleteQuery(Convert.ToInt32(id));
            TableData.ItemsSource = table.GetData();
        }

        private void Button_Update_Click(object sender, RoutedEventArgs e)
        {
            int numbers = Int32.Parse(Table_TextBox.Text);
            object id = (TableData.SelectedItem as DataRowView).Row[0];
            table.UpdateQuery(numbers, Convert.ToInt32(id));
            TableData.ItemsSource = table.GetData();
        }


    }
}
