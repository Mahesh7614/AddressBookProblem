using AddressBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Repository
{
    internal class ContactDetailsRepository
    {
        public Dictionary<long, ContactDetails> contactDetailDictionary = new Dictionary<long, ContactDetails>();

        public void AddContactDetails(string firstName, string LastName, long mobileNumber, string email, string address, string state, string city, int zip)
        {
            ContactDetails contactDetails = new ContactDetails();
            contactDetailDictionary.Add(mobileNumber, contactDetails);
        }
       
    }
}
