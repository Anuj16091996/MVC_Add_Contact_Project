using BLL;
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

namespace View_Project.View
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : UserControl
    {
        public Search()
        {
            InitializeComponent();
        }

        Contact con = new Contact();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            string name = Edit_Block.Text;

            con = Manager_Project.EditContact(name);

            if(con.Phone_Number==0)
            {
                MessageBox.Show("No Data Found", "No DataBase",
                 MessageBoxButton.OK, MessageBoxImage.Information);
                Edit_Block.Clear();
                Show_Block.Clear();
            }

            else
            {

                Edit_Block.Clear();

                Show_Block.Text = con.First_name + " " + con.Last_Name + " "
                    + con.Phone_Number + "\n" +
                    "";

            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Edit_Block.Clear();
            Show_Block.Clear();

            

           List<Contact> display = Manager_Project.DisplayAllContact();

            foreach (var item in display)
            {
                Show_Block.Text += item.First_name + " " + item.Last_Name + " "
                + item.Phone_Number + "\n" +
                "";
            }

            


        }

        
    }
}
