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
    /// Interaction logic for DeleteContact.xaml
    /// </summary>
    public partial class DeleteContact : UserControl
    {
        public DeleteContact()
        {
            InitializeComponent();
            DelteBtn.Visibility = Visibility.Collapsed;
            Cancel_edit.Visibility = Visibility.Collapsed;
        }

        Contact con = new Contact();
        long number;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
           number = long.Parse(Edit_Block.Text);
            }catch(Exception)
            {
                MessageBox.Show("Check The Input", "Error",
                           MessageBoxButton.OK,
                           MessageBoxImage.Warning);

                Edit_Block.Clear();

                return;
            }

            con = Manager_Project.FindNumber(number);

            if(con.Phone_Number==0)
            {
                MessageBox.Show("No Data Found", "No DataBase",
                MessageBoxButton.OK, MessageBoxImage.Information);
                Edit_Block.Clear();
                Show_Block.Clear();
                DelteBtn.Visibility = Visibility.Collapsed;
                Cancel_edit.Visibility = Visibility.Collapsed;
            }
            else
            {

                Edit_Block.Clear();

                Show_Block.Text = con.First_name + " " + con.Last_Name + " "
                    + con.Phone_Number + "\n" +
                    "";

                DelteBtn.Visibility = Visibility.Visible;
                Cancel_edit.Visibility = Visibility.Visible;


            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Manager_Project.DeleteNumber(number);
            MessageBox.Show("Contact Deleted", "Operration Sucessfull");
            Show_Block.Clear();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
