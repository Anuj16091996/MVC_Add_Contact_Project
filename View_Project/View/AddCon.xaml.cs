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
    /// Interaction logic for AddCon.xaml
    /// </summary>
    public partial class AddCon : UserControl
    {
        public Contact con = new Contact();

        public AddCon()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Add_Cont_Click(object sender, RoutedEventArgs e)
        {
            con.First_name = (Add_Conts.Text);
            con.Last_Name = (Last_Name.Text);

            try
            {

                con.Phone_Number = long.Parse(Phone_Number.Text);


            }
            catch (System.FormatException r)
            {
                MessageBox.Show("Please fill in all fields", "Error",
                                   MessageBoxButton.OK, MessageBoxImage.Error);
                Add_Conts.Clear();
                Phone_Number.Clear();
                Last_Name.Clear();
                return;
            }
            int datass = Manager_Project.Status_check(con);

            switch(datass)
            {
                case 1:
                    bool status = Manager_Project.FindNumber(con);
                    if(status==false)
                    {
                        MessageBox.Show("Number Already In database", "Error",
                                       MessageBoxButton.OK, MessageBoxImage.Error);
                        Add_Conts.Clear();
                        Phone_Number.Clear();
                        Last_Name.Clear();
                        return;
                    }

                    else
                    {
                        Manager_Project.AddContact(con);
                        Add_Conts.Clear();
                        Last_Name.Clear();
                        Phone_Number.Clear();

                        MessageBox.Show("Your Contact Added", "Contact Added");
                        
                    }

                    break;

                case 2:

                    MessageBox.Show("Please fill the Name ", "Error",
                  MessageBoxButton.OK, MessageBoxImage.Error);
                    Last_Name.Clear();
                    Phone_Number.Clear();
                    return;
                    break;

                case 3:
                    MessageBox.Show("Please fill in all fields", "Error",
                 MessageBoxButton.OK, MessageBoxImage.Error);
                    Add_Conts.Clear();
                    Phone_Number.Clear();
                    Last_Name.Clear();
                    return;

                    break;


                case 4:

                    MessageBox.Show("Number should be 10 digits", "Error",
               MessageBoxButton.OK, MessageBoxImage.Error);
                    Add_Conts.Clear();
                    Phone_Number.Clear();
                    Last_Name.Clear();
                    return;
                    break;

            }

      

        }


    }
}
