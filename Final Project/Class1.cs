using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Model
{
    public class Contact
    {
        static int counts = 0;
        public string First_name { get; set; }

        public string Last_Name { get; set; }

        public long Phone_Number { get; set; }

        public override string ToString()
        {
          
            return string.Format("{0},{1},{2}",First_name, Last_Name
            ,Phone_Number);
        }

    }
}
