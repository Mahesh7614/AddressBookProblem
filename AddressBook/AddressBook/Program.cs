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

            ContactDetailsRepository contactDetailsRepository = new ContactDetailsRepository();
            contactDetailsRepository.AddContactDetails("Mahesh", "Waghmare", 9028876143, "waghmaremahesh012@gmail.com", "Hari om Niwas, Nagoba Nagar", "Maharashtra", "Ahmedpur", 413515);
            contactDetailsRepository.AddContactDetails("Yashwamt", "Kadam", 8856956513, "yashwant151197@gmail.com", "Holkar Nagar", "Maharashtra", "Parbhani", 431401);
        }
    }
}