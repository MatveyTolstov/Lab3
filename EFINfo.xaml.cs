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
    /// Логика взаимодействия для EFINfo.xaml
    /// </summary>
    public partial class EFINfo : Window
    {
        private NIGHTCLUBEntities3 NIGHTCLUBEntities3 = new NIGHTCLUBEntities3();
        public EFINfo()
        {
            InitializeComponent();

            Efful.ItemsSource = NIGHTCLUBEntities3.TABLEBOOKING.ToList();

        }

        
    }
}
