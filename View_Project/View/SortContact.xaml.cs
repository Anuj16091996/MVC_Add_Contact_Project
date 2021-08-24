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
    /// Interaction logic for SortContact.xaml
    /// </summary>
    public partial class SortContact : UserControl
    {
        public SortContact()
        {
            InitializeComponent();
        }
        

        private void DelteBtn_Click(object sender, RoutedEventArgs e)
        {
            Show_Block.Clear();
            List<Contact> cons = Manager_Project.SortByNumber();

            foreach (var con in cons)
            {
                Show_Block.Text += con.First_name + " " + con.Last_Name + " "
                  + con.Phone_Number + "\n" +
                  "";
            }
        }

      

        
    }
}
