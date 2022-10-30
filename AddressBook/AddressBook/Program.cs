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
            ContactDetailsRepository contactDetailsRepository = new ContactDetailsRepository();

            Console.Write("Enter 'y' to Enter Contact Details : ");
            var input = Console.ReadLine();
            
            while (input == "y")
            {
                Console.Write("Enter Unique Name to Address Book : ");
                string uniqueName = Console.ReadLine();

                Console.Write("Enter First Name : ");
                string firstName = Console.ReadLine();

                Console.Write("Enter Last Name : ");
                string lastName = Console.ReadLine();
                 
                Console.Write("Enter Mobile Number : ");
                long mobileNumber = Convert.ToInt64(Console.ReadLine());

                Console.Write("Enter Email ID : ");
                string email = Console.ReadLine();

                Console.Write("Enter Address : ");
                string address = Console.ReadLine();

                Console.Write("Enter City : ");
                string city = Console.ReadLine();
                
                Console.Write("Enter District : ");
                string dist = Console.ReadLine();

                Console.Write("Enter State : ");
                string state = Console.ReadLine();

                Console.Write("Enter Zip Code : ");
                int zip = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter 'y' to Enter Contact Details or otherwise Enter any key : ");
                input = Console.ReadLine();

                contact = new ContactDetails()
                {
                    UniqueName = uniqueName,
                    FirstName = firstName,
                    LastName = lastName,
                    MobileNumber = mobileNumber,
                    Email = email,
                    Address = address,
                    State = state,
                    City = city,
                    District = dist,
                    Zip = zip

                };
                contactDetailsRepository.AddContactDetails(contact);
            }
            Console.Write("Enter 'g' to get Contact Details by First Name : ");           
            var name = Console.ReadLine();          
            while (name == "g")
            {
                Console.Write("Enter First Name : ");
                contactDetailsRepository.GetUsingFirstName(Console.ReadLine());
                Console.Write("Enter 'g' to get Contact Details by First Name otherwise Enter any key : ");
                name = Console.ReadLine();            
            }
            Console.Write("Enter 'e' to edit contact using Unique Name : ");           
            var edit = Console.ReadLine();          
            while (edit == "e")
            {
                Console.Write("Enter Unique Name : ");
                contactDetailsRepository.EditContactDetails(Console.ReadLine());
               
                Console.Write("Enter 'e' to edit contact using Unique Name otherwise Enter any key : ");
                edit = Console.ReadLine();            
            }
            Console.Write("Enter 'f' to edit contact using First Name : ");
            var editf = Console.ReadLine();
            while (editf == "f")
            {
                Console.Write("Enter First Name : ");
                contactDetailsRepository.EditContactDetailsByFirstName(Console.ReadLine());

                Console.Write("Enter 'f' to edit contact using First Name otherwise Enter any key : ");
                editf = Console.ReadLine();
            }
            Console.Write("Enter 'd' to delete contact using Unique Name : ");
            var delete = Console.ReadLine();
            while (delete == "d")
            {
                Console.Write("Enter Unique Name Which you want to Delete Contact : ");
                contactDetailsRepository.DeleteContact(Console.ReadLine());
                Console.Write("Enter 'd' to Delete contact using Unique Name otherwise Enter any key : ");
                delete = Console.ReadLine();
            }

            contactDetailsRepository.DisplayContact();
        }
    }
    
}

                


