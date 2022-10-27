using AddressBook.Model;
using AddressBook.Repository;
using System;
using System.Diagnostics.Contracts;
using System.Net;

namespace AddressBook
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book \n");
            
            ContactDetails contact = null;
            
            Console.WriteLine("Enter y to Enter Contact Details : ");
            var input = Console.ReadLine();
            
            while (input == "y")
            {
                Console.WriteLine("Enter First Name : ");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name :");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter Mobile Number :");
                long mobileNumber = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Enter Email ID : ");
                string email = Console.ReadLine();

                Console.WriteLine("Enter Address : ");
                string address = Console.ReadLine();

                Console.WriteLine("Enter City : ");
                string city = Console.ReadLine();

                Console.WriteLine("Enter State : ");
                string state = Console.ReadLine();

                Console.WriteLine("Enter Zip Code : ");
                int zip = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter y to Enter Contact Details or otherwise enter any key : ");
                input = Console.ReadLine();

                contact = new ContactDetails()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    MobileNumber = mobileNumber,
                    Email = email,
                    Address = address,
                    State = state,
                    City = city,
                    Zip = zip

                };       
            }
            ContactDetails contact1 = new ContactDetails()
            {
                FirstName = "Mahesh",
                LastName = "Waghmare",
                MobileNumber = 9028876143,
                Email = "waghmaremahesh012@gmail.com",
                Address = "Hari Om Niwas, Nagoba Nagar",
                City = "Ahmedpur",
                State = "Maharashtra",
                zip = 413515
            };
            ContactDetails contact2 = new ContactDetails()
            {
                FirstName = "Yashwant",
                LastName = "Kadam",
                MobileNumber = 8856956513,
                Email = "yashwant151197@gmail.com",
                Address = "Holkar Nagar",
                City = "Parbhani",
                State = "Maharashtra",
                zip = 431402
            };

            ContactDetailsRepository contactDetailsRepository1 = new ContactDetailsRepository();
            contactDetailsRepository1.AddContactDetails(contact1);
            contactDetailsRepository1.AddContactDetails(contact2);
            contactDetailsRepository1.DisplayContact();
            ContactDetailsRepository contactDetailsRepository = new ContactDetailsRepository();
            contactDetailsRepository.AddContactDetails(contact);
            contactDetailsRepository.DisplayContact();


            
        }
    }
    
}

                


