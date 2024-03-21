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
using System.Windows.Navigation;
using System.Windows.Shapes;


using Laboratornaya1.laba1DataSetTableAdapters;

namespace Laboratornaya1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {  
        UsersTableAdapter users = new UsersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            UsersDgr.ItemsSource = users.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UsersDgr.ItemsSource = users.SearchByName(SearchTxt.Text);
        }
    }
}
