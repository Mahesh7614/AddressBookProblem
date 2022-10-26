using AddressBook.Model;
using AddressBook.Repository;
using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");

            ContactDetails contact = new ContactDetails()
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
            ContactDetails contact1 = new ContactDetails()
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



            ContactDetailsRepository contactDetailsRepository = new ContactDetailsRepository();
            contactDetailsRepository.AddContactDetails(contact);
            contactDetailsRepository.AddContactDetails(contact1);
            contactDetailsRepository.DisplayContact();
        }
    }
    
}