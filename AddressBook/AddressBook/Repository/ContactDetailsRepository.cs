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

        public void AddContactDetails(ContactDetails contactDetails)
        {
            contactDetailDictionary.Add(Convert.ToInt64(contactDetails.MobileNumber), contactDetails);
        }
        public void EditContactDetails(long mobilenumber)
        {
            var obj = contactDetailDictionary[mobilenumber];
            contactDetailDictionary.Remove(mobilenumber);
            Console.WriteLine("Select Which Detail you want to Edit : \n1. First Name \n2. Last Name \n3. Mobile Number \n4. Email ID \n5. Address \n6. City \n7. District \n8. State \n9. Zip Code");
            Console.Write("Enter the Selected Number to Edit : ");
            int editDetail = Convert.ToInt32(Console.ReadLine());
            switch (editDetail)
            {
                case 1:
                    Console.Write("Enter First Name to Update : ");
                    string firstName =Console.ReadLine();
                    obj.FirstName = firstName;
                    contactDetailDictionary.Add(Convert.ToInt64(obj.MobileNumber), obj);
                    break;
                case 2:
                    Console.Write("Enter Last Name to Update : ");
                    string lastName =Console.ReadLine();
                    obj.LastName = lastName;
                    contactDetailDictionary.Add(Convert.ToInt64(obj.MobileNumber), obj);
                    break;
                case 3:
                    Console.Write("Enter Mobile Number to Update : ");
                    long mobNumber =Convert.ToInt64(Console.ReadLine());
                    obj.MobileNumber = mobNumber;
                    contactDetailDictionary.Add(Convert.ToInt64(obj.MobileNumber), obj);
                    break;
                case 4:
                    Console.Write("Enter Email ID to Update : ");
                    string email =Console.ReadLine();
                    obj.Email = email;
                    contactDetailDictionary.Add(Convert.ToInt64(obj.MobileNumber), obj);
                    break;
                case 5:
                    Console.Write("Enter Address to Update : ");
                    string address =Console.ReadLine();
                    obj.Address = address;
                    contactDetailDictionary.Add(Convert.ToInt64(obj.MobileNumber), obj);
                    break;
                case 6:
                    Console.Write("Enter City to Update : ");
                    string city = Console.ReadLine();
                    obj.City = city;
                    contactDetailDictionary.Add(Convert.ToInt64(obj.MobileNumber), obj);
                    break;
                case 7:
                    Console.Write("Enter District to Update : ");
                    string district = Console.ReadLine();
                    obj.District = district;
                    contactDetailDictionary.Add(Convert.ToInt64(obj.MobileNumber), obj);
                    break;
                case 8:
                    Console.Write("Enter State to Update : ");
                    string state =Console.ReadLine();
                    obj.State = state;
                    contactDetailDictionary.Add(Convert.ToInt64(obj.MobileNumber), obj);
                    break;
                case 9:
                    Console.Write("Enter First Name to Update : ");
                    int zipcode =Convert.ToInt32(Console.ReadLine());
                    obj.Zip = zipcode;
                    contactDetailDictionary.Add(Convert.ToInt64(obj.MobileNumber), obj);
                    break;
            }
            
        }
        public void EditContactDetailsByFirstName(string fName)
        {
            var persiondetail = GetUsingFirstNameDetail(fName);
            contactDetailDictionary.Remove(Convert.ToInt64(persiondetail.MobileNumber));
            Console.WriteLine("Select Which Detail you want to Edit : \n1. First Name \n2. Last Name \n3. Mobile Number \n4. Email ID \n5. Address \n6. City \n7. District \n8. State \n9. Zip Code");
            Console.Write("Enter the Selected Number to Edit : ");
            int editDetail = Convert.ToInt32(Console.ReadLine());
            switch (editDetail)
            {
                case 1:
                    Console.Write("Enter First Name to Update : ");
                    string firstName = Console.ReadLine();
                    persiondetail.FirstName = firstName;
                    contactDetailDictionary.Add(Convert.ToInt64(persiondetail.MobileNumber), persiondetail);
                    break;
                case 2:
                    Console.Write("Enter Last Name to Update : ");
                    string lastName = Console.ReadLine();
                    persiondetail.LastName = lastName;
                    contactDetailDictionary.Add(Convert.ToInt64(persiondetail.MobileNumber), persiondetail);
                    break;
                case 3:
                    Console.Write("Enter Mobile Number to Update : ");
                    long mobNumber = Convert.ToInt64(Console.ReadLine());
                    persiondetail.MobileNumber = mobNumber;
                    contactDetailDictionary.Add(Convert.ToInt64(persiondetail.MobileNumber), persiondetail);
                    break;
                case 4:
                    Console.Write("Enter Email ID to Update : ");
                    string email = Console.ReadLine();
                    persiondetail.Email = email;
                    contactDetailDictionary.Add(Convert.ToInt64(persiondetail.MobileNumber), persiondetail);
                    break;
                case 5:
                    Console.Write("Enter Address to Update : ");
                    string address = Console.ReadLine();
                    persiondetail.Address = address;
                    contactDetailDictionary.Add(Convert.ToInt64(persiondetail.MobileNumber), persiondetail);
                    break;
                case 6:
                    Console.Write("Enter City to Update : ");
                    string city = Console.ReadLine();
                    persiondetail.City = city;
                    contactDetailDictionary.Add(Convert.ToInt64(persiondetail.MobileNumber), persiondetail);
                    break;
                case 7:
                    Console.Write("Enter District to Update : ");
                    string district = Console.ReadLine();
                    persiondetail.District = district;
                    contactDetailDictionary.Add(Convert.ToInt64(persiondetail.MobileNumber), persiondetail);
                    break;
                case 8:
                    Console.Write("Enter State to Update : ");
                    string state = Console.ReadLine();
                    persiondetail.State = state;
                    contactDetailDictionary.Add(Convert.ToInt64(persiondetail.MobileNumber), persiondetail);
                    break;
                case 9:
                    Console.Write("Enter First Name to Update : ");
                    int zipcode = Convert.ToInt32(Console.ReadLine());
                    persiondetail.Zip = zipcode;
                    contactDetailDictionary.Add(Convert.ToInt64(persiondetail.MobileNumber), persiondetail);
                    break;
            }
        }
        public ContactDetails GetUsingFirstNameDetail(string firstName)
        {
            foreach (var item in contactDetailDictionary)
            {
                if (item.Value.FirstName.Contains(firstName))
                {
                    return item.Value;
                }
            }
            return null;
        }
        public void GetUsingFirstName(string firstName)
        {
            foreach (var item in contactDetailDictionary)
            {
                if (item.Value.FirstName == firstName)
                {
                    item.Value.FirstName.Contains(firstName);
                    Console.WriteLine("First Name is : " + item.Value.FirstName);
                    Console.WriteLine("Last Name is : " + item.Value.LastName);
                    Console.WriteLine("Mobile Number is : " + item.Value.MobileNumber);
                    Console.WriteLine("Email ID is : " + item.Value.Email);
                    Console.WriteLine("Address is : " + item.Value.Address);
                    Console.WriteLine("City is : " + item.Value.City);
                    Console.WriteLine("District is : " + item.Value.District);
                    Console.WriteLine("State is : " + item.Value.State);
                    Console.WriteLine("Zip Code is : " + item.Value.Zip);
                }
            }
        }
        public void DeleteContact(long mobNumber)
        {
            contactDetailDictionary.Remove(mobNumber);
        }
        public void DisplayContact()
        {
            foreach (var item in contactDetailDictionary)
            {
                Console.WriteLine("First Name is : " + item.Value.FirstName);
                Console.WriteLine("Last Name is : " + item.Value.LastName);
                Console.WriteLine("Mobile Number is : " + item.Value.MobileNumber);
                Console.WriteLine("Email ID is : " + item.Value.Email);
                Console.WriteLine("Address is : " + item.Value.Address);
                Console.WriteLine("City is : " + item.Value.City);
                Console.WriteLine("District is : " + item.Value.District);
                Console.WriteLine("State is : " + item.Value.State);               
                Console.WriteLine("Zip Code is : " + item.Value.Zip);
            }
        }

    }
}
