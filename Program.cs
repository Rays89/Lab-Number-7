using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_Number_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid Name:");
            string input = Console.ReadLine();
            Names(input);//calling the method eg for the name

            Console.WriteLine("please enter a valid email:");
            input = Console.ReadLine();
            Emails(input);

            Console.WriteLine("Please enter a valid phone number:");
            input = Console.ReadLine();
            phonenumber(input);

            Console.WriteLine("Please enter a valid Date:");
            input = Console.ReadLine();
            Date(input);

        }

        public static void Names(string input)
        {


            //string Input = Console.ReadLine();
            if (Regex.IsMatch(input, "^[A-Z][a-zA-Z]{2,30}$"))
            {

                Console.WriteLine("Oh, thank you, name is valid:");
                //return true;

            }
            else
            {

                Console.WriteLine("Sorry, name is not valid!");
                //input = Console.ReadLine();
                //return false;

            }


        }

        public static void Emails(string input)
        {

            //string Input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^[A-Za-z0-9._%+-]{3,}@[A-Za-z0-9.-]{2,15}[.][A-Za-z]{2,}$"))
            {
                Console.WriteLine("Thank you. Email is valid:");
                //return true;
                //Input = Console.ReadLine();


            }
            else
            {

                Console.WriteLine("Email is not valid");
                //return false;

            }





        }

        public static void phonenumber(string input)
        {

            //string Input = Console.ReadLine();

            if (Regex.IsMatch(input, @"^\d{3}-\d{3}-\d{4}$"))
                {

                Console.WriteLine("Thank you, phone is valid");
                //return false;

            }
           else 
            {

                Console.WriteLine("Sorry, phone is not valid");
                //return true;
            }


        }

        public static void Date (string input)

        {
            //string Input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^[0-3][0-9]/[0-1][0-9]/\d{4}$"))

            {

                Console.WriteLine("Thank you. Date is valid");
                //return false;

            }
            else
            {

                Console.WriteLine("sorry, Date is not valid!");
                //return true;
            }

        }



    }


}


           
            
            


   