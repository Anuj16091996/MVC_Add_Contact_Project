using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Final_Project_Model;
using System.Text.RegularExpressions;

namespace DAL_Project
{
    public static class Service
    {
        public static string filepath = "../../Contact.txt";

        public static void AddContactToFile(Contact con)
        {
            string str = string.Format("{0},{1},{2}\n", con.First_name, con.Last_Name
            , con.Phone_Number);


            File.AppendAllText(filepath, str);
        }


        public static List<Contact> ReadAllContcat()
        {
            List<Contact> con = new List<Contact>();

            string[] lines = File.ReadAllLines(filepath);

            foreach (var item in lines)
            {
                string[] data = item.Split(',');


                con.Add(new Contact()
                {
                    First_name = data[0],
                    Last_Name = data[1],
                    Phone_Number = long.Parse(data[2])
                }
                                );


            }



            return con;
        }


        public static Contact FindContact(string fname)
        {
            List<Contact> con = ReadAllContcat();

            Contact cons = new Contact();

            foreach (var item in con)
            {
                if (item.First_name == fname)
                {
                    cons.First_name = item.First_name;
                    cons.Last_Name = item.Last_Name;
                    cons.Phone_Number = item.Phone_Number;
                }
            }

            return cons;
        }

        public static Contact FindContactNumber(long num)
        {
            List<Contact> con = ReadAllContcat();

            Contact cons = new Contact();

            foreach (var item in con)
            {
                if (item.Phone_Number == num)
                {
                    cons.First_name = item.First_name;
                    cons.Last_Name = item.Last_Name;
                    cons.Phone_Number = item.Phone_Number;
                }
            }

            return cons;
        }


        public static List<Contact> DisplayAllContact()
        {
            List<Contact> con = ReadAllContcat();

            List<Contact> cons = new List<Contact>();

            foreach (var item in con)
            {

                cons.Add(new Contact
                {
                    First_name = item.First_name,
                    Last_Name = item.Last_Name,
                    Phone_Number = item.Phone_Number
                });


            }

            return cons;
        }

        public static long FindNumber(string name, long num)
        {
            List<Contact> con = ReadAllContcat();

            Contact cons = new Contact();

            foreach (var item in con)
            {
                if (item.First_name == name)
                {
                    cons.First_name = item.First_name;
                    cons.Last_Name = item.Last_Name;
                    cons.Phone_Number = item.Phone_Number;
                }
            }

            return cons.Phone_Number;
        }



        public static bool FindNumber(Contact conss)
        {
            bool status = true;
            string[] lines = File.ReadAllLines(filepath);

            List<Contact> con = ReadAllContcat();


            foreach (var item in con)
            {
                if (item.Phone_Number == conss.Phone_Number)
                {
                    status = false;
                }
            }

            return status;
        }

        public static void UpdateDatabase(long num, Contact con)
        {
            string[] lines = File.ReadAllLines
                (filepath);

            for (int i = 0; i < lines.Length; i++)
            {

                string[] data = lines[i].Split(',');
                string First_name = data[0];
                string Last_Name = data[1];
                long Phone_Number = long.Parse(data[2]);

                if (Phone_Number == num)
                {
                    lines[i] = con.ToString();


                }



            }

            File.WriteAllLines(filepath, lines);

        }

        public static void DeleteNumber(long num)
        {
            string[] lines = File.ReadAllLines(filepath);

            //  List<string> lin = File.ReadAllLines(filepath).ToList();

            int lenght = lines.Length;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                string First_name = data[0];
                string Last_Name = data[1];
                long Phone_Number = long.Parse(data[2]);

                if (Phone_Number == num)
                {


                    for (int j = i; j < lines.Length - 1; j++)
                    {
                        lines[j] = lines[j + 1];

                        if (j == lines.Length - 1)
                        {

                            lines[j] = string.Empty;
                            break;
                        }
                    }



                }
            }

            for (int i = 0; i < lines.Length; i++)
            {
                lines[lines.Length - 1] = "";
            }


            File.WriteAllLines(filepath, lines);


            string[] text = File.ReadAllLines(filepath).Where(s => s.Trim() != string.Empty).ToArray();

            File.Delete(filepath);

            File.WriteAllLines(filepath, text);





        }

        public static List<Contact> SortbyNumber()
        {
            List<Contact> cons = ReadAllContcat();

            for (int i = 0; i < cons.Count; i++)
            {

                for (int j = 0; j < cons.Count-1; j++)
                {
                    if (cons[j].Phone_Number > cons[j + 1].Phone_Number)
                    {
                        Contact temp = cons[j];
                        cons[j] = cons[j+ 1];
                        cons[j + 1] = temp;
                    }
                }
            }
            return cons;
        }

    






    }
}
