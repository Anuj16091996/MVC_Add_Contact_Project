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
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : UserControl
    {
        Contact con = new Contact();

        public Edit()
        {
            InitializeComponent();
            NameLabel.Visibility = Visibility.Collapsed;
            NameLabel_Copy.Visibility = Visibility.Collapsed;
            NameLabel_Copy1.Visibility = Visibility.Collapsed;
            Edit_Btn.Visibility = Visibility.Collapsed;
            FirstName.Visibility = Visibility.Collapsed;
            Last_Name.Visibility = Visibility.Collapsed;
            Phone_Number.Visibility = Visibility.Collapsed;
        }

        long finalnumber;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = Edit_Block.Text;

            Edit_Block.Clear();

            Contact cons = Manager_Project.EditContact(name);

            if(cons.Phone_Number==0)
            {
                MessageBox.Show("No Data Found", "No DataBase",
                 MessageBoxButton.OK, MessageBoxImage.Information);
            }

            else
            {
                finalnumber = Manager_Project.FindNumber(name,cons.Phone_Number);

                    Show_Block.Text = cons.First_name + " "+ cons.Last_Name +" "
                        + cons.Phone_Number +"\n" +
                        "";
                

                NameLabel.Visibility = Visibility.Visible;
                NameLabel_Copy.Visibility = Visibility.Visible;
                NameLabel_Copy1.Visibility = Visibility.Visible;
                Edit_Btn.Visibility = Visibility.Visible ;
                FirstName.Visibility = Visibility.Visible;
                Last_Name.Visibility = Visibility.Visible;
                Phone_Number.Visibility = Visibility.Visible;


               
               



            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
         
            con.First_name = FirstName.Text;
            con.Last_Name = Last_Name.Text;

            try
            {
                con.Phone_Number = long.Parse(Phone_Number.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Check The Input", "Error",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);

                FirstName.Clear();
                Last_Name.Clear();
                Phone_Number.Clear();
                return;
            }

            


            int datass = Manager_Project.Status_check(con);

            switch (datass)
            {
                case 1:
                    bool status = Manager_Project.FindNumber(con);
                    if (status == false)
                    {
                        MessageBox.Show("Number Already In database", "Error",
                                       MessageBoxButton.OK, MessageBoxImage.Error);
                        FirstName.Clear();
                        Last_Name.Clear();
                        Phone_Number.Clear();
                        return;
                    }

                    else
                    {
                        Manager_Project.UpdateDatabase(finalnumber, con);
                        FirstName.Clear();
                        Last_Name.Clear();
                        Phone_Number.Clear();

                        MessageBox.Show("Your Contact Added", "Contact Added");
                        NameLabel.Visibility = Visibility.Collapsed;
                        NameLabel_Copy.Visibility = Visibility.Collapsed;
                        NameLabel_Copy1.Visibility = Visibility.Collapsed;
                        Edit_Btn.Visibility = Visibility.Collapsed;
                        FirstName.Visibility = Visibility.Collapsed;
                        Last_Name.Visibility = Visibility.Collapsed;
                        Phone_Number.Visibility = Visibility.Collapsed;
                        Show_Block.Clear();
                    }
                    

                    break;

                case 2:

                    MessageBox.Show("Please fill the Name ", "Error",
                  MessageBoxButton.OK, MessageBoxImage.Error);
                    FirstName.Clear();
                    Last_Name.Clear();
                    Phone_Number.Clear();
                    return;
                    break;

                case 3:
                    MessageBox.Show("Please fill in all fields", "Error",
                 MessageBoxButton.OK, MessageBoxImage.Error);
                    FirstName.Clear();
                    Last_Name.Clear();
                    Phone_Number.Clear();
                    return;

                    break;


                case 4:

                    MessageBox.Show("Number should be 10 digits", "Error",
               MessageBoxButton.OK, MessageBoxImage.Error);
                    FirstName.Clear();
                    Last_Name.Clear();
                    Phone_Number.Clear();
                    return;
                    break;

            }

        }
    }
}
