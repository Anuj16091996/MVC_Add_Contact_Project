using DAL_Project;
using Final_Project_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Manager_Project
    {
        public static int Status_check(Contact con)
        {

            int data = 1;

            if (con.First_name == "")
            {
                data = 2;
            }

            if (con.Last_Name == "")
            {
                data = 3;
            }

            if(con.Phone_Number<1000000000 || con.Phone_Number>9999999999)
            {
                data = 4;
            }


            return data;

        }

        public static void AddContact(Contact con)
        {
            Service.AddContactToFile(con);
        }


        public static List<Contact> DisplayContact()
        {
           return Service.ReadAllContcat();
        }

        public static Contact EditContact(string fname)
        {
            return Service.FindContact(fname);
        }

        public static long FindNumber(string name, long num)
        {
            return Service.FindNumber(name,num);
        }

        public static bool FindNumber(Contact con)
        {
            return Service.FindNumber(con);
        }

        public static void UpdateDatabase(long num,Contact con)
        {
             Service.UpdateDatabase(num,con);
        }

        public static List<Contact> DisplayAllContact()
        {
            return Service.DisplayAllContact();
        }

        public static Contact FindNumber(long num)
        {
            return Service.FindContactNumber(num);
        }

        public static void DeleteNumber(long num)
        {
            Service.DeleteNumber(num);
        }

        public static List<Contact>SortByNumber()
        {
            return Service.SortbyNumber();
        }

       

    }
}
