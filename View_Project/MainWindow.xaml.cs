using Final_Project_Model;
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
using View_Project.View;

namespace View_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Add_Contact_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new AddCon();
        }

        private void Edit_Contact_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Edit();

        }

       

        private void Delete_Contact_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new DeleteContact();
        }

        private void Search_Contact_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Search();
        }

        private void Sort_Contact_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new SortContact();
        }
    }
}
