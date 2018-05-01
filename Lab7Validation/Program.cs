using System;
using System.Text.RegularExpressions;


namespace Lab7Validation
{
    class Program
    {
        static void Main(string[] args)
        {         
            GetName();
            GetEmail();
            GetPhoneNumber();
            GetDate();
            GetHTML();
        }
        static void GetName()
        {
            Console.Write("Please enter a valid name: ");
            string Input = Console.ReadLine();

            //Input = Regex.Replace(Input, " ", "");
            Regex NameValidation = new Regex(@"\b[A-Z]{1}[a-z]{1,30}\b");

            if (NameValidation.IsMatch(Input))
            {
                Console.WriteLine("Your name is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, name is not valid!");
            }

        }
        static void GetEmail()
        {
            Regex EmailValidation = new Regex(@"[\w.]{5,30}@[\w]{5,10}.\w{2,3}");

            Console.Write("Please enter a valid email: ");
            string Input = Console.ReadLine();

            if (EmailValidation.IsMatch(Input))
            {
                Console.WriteLine("Email is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, email is not valid!");
            }
        }
        static void GetPhoneNumber()
        {
            Regex PhoneValidation = new Regex(@"\b[\d]{3}-[\d]{3}-[\d]{4}\b");

            Console.Write("Please enter a valid phone number: ");
            string Input = Console.ReadLine();

            if (PhoneValidation.IsMatch(Input))
            {
                Console.WriteLine("Phone number is valid! ");
            }
            else
            {
                Console.WriteLine("Sorry, phone number is not valid!");
            }
        }
        static void GetDate()
        {
            Regex DateValidation = new Regex(@"\b[\d]{2}/[\d]{2}/[\d]{4}\b");

            Console.Write("Please enter a valid date: ");
            string Input = Console.ReadLine();

            if (DateValidation.IsMatch(Input))
            {
                Console.WriteLine("Date is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, date is not valid");
            }
        }
        static void GetHTML()
        {
            Regex HTMLValidation = new Regex(@"<[\/\w]{1,}>");

            Console.Write("Please enter a valid HTML element: ");
            string Input = Console.ReadLine();

            if (HTMLValidation.IsMatch(Input))
            {
                Console.WriteLine("HTML element is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, HTML element is not valid");
            }
        }
    }
}
