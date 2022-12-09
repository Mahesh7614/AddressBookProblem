using AddressBook.Model;
using System.Transactions;

namespace AddressBook.Repository
{
    internal class ContactDetailsRepository
    {
        public Dictionary<string, ContactDetails> contactDetailDictionary = new Dictionary<string, ContactDetails>();
        public void AddContactDetails(ContactDetails contactDetails)
        {
            var contact = contactDetailDictionary.SingleOrDefault(detail => detail.Value.Equals(contactDetails));
            if (contact.Value == null)
            {
                contactDetailDictionary.Add(contactDetails.UniqueName, contactDetails);
            }
            else
            {
                Console.WriteLine($"\nThe Contact Name {contactDetails.FirstName} is Already Exists");
            }
        }
        public void EditContactDetails(string UniqueName)
        {
            var obj = contactDetailDictionary[UniqueName];
            Console.WriteLine("Select Which Detail you want to Edit : \n1. First Name \n2. Last Name \n3. Mobile Number \n4. Email ID \n5. Address \n6. City \n7. District \n8. State \n9. Zip Code");
            Console.Write("Enter the Selected Number to Edit : ");
            int editDetail = Convert.ToInt32(Console.ReadLine());
            switch (editDetail)
            {
                case 1:
                    Console.Write("Enter First Name to Update : ");
                    string firstName = Console.ReadLine();
                    obj.FirstName = firstName;
                    break;
                case 2:
                    Console.Write("Enter Last Name to Update : ");
                    string lastName = Console.ReadLine();
                    obj.LastName = lastName;
                    break;
                case 3:
                    Console.Write("Enter Mobile Number to Update : ");
                    long mobNumber = Convert.ToInt64(Console.ReadLine());
                    obj.MobileNumber = mobNumber;
                    break;
                case 4:
                    Console.Write("Enter Email ID to Update : ");
                    string email = Console.ReadLine();
                    obj.Email = email;
                    break;
                case 5:
                    Console.Write("Enter Address to Update : ");
                    string address = Console.ReadLine();
                    obj.Address = address;
                    break;
                case 6:
                    Console.Write("Enter City to Update : ");
                    string city = Console.ReadLine();
                    obj.City = city;
                    break;
                case 7:
                    Console.Write("Enter District to Update : ");
                    string district = Console.ReadLine();
                    obj.District = district;
                    break;
                case 8:
                    Console.Write("Enter State to Update : ");
                    string state = Console.ReadLine();
                    obj.State = state;
                    break;
                case 9:
                    Console.Write("Enter Zip Code to Update : ");
                    int zipcode = Convert.ToInt32(Console.ReadLine());
                    obj.Zip = zipcode;
                    break;
            }
        }
        public void EditContactDetailsByFirstName(string fName)
        {
            var persiondetail = GetUsingFirstNameDetail(fName);
            Console.WriteLine("Select Which Detail you want to Edit : \n1. First Name \n2. Last Name \n3. Mobile Number \n4. Email ID \n5. Address \n6. City \n7. District \n8. State \n9. Zip Code");
            Console.Write("Enter the Selected Number to Edit : ");
            int editDetail = Convert.ToInt32(Console.ReadLine());
            switch (editDetail)
            {
                case 1:
                    Console.Write("Enter First Name to Update : ");
                    string firstName = Console.ReadLine();
                    persiondetail.FirstName = firstName;
                    break;
                case 2:
                    Console.Write("Enter Last Name to Update : ");
                    string lastName = Console.ReadLine();
                    persiondetail.LastName = lastName;
                    break;
                case 3:
                    Console.Write("Enter Mobile Number to Update : ");
                    long mobNumber = Convert.ToInt64(Console.ReadLine());
                    persiondetail.MobileNumber = mobNumber;
                    break;
                case 4:
                    Console.Write("Enter Email ID to Update : ");
                    string email = Console.ReadLine();
                    persiondetail.Email = email;
                    break;
                case 5:
                    Console.Write("Enter Address to Update : ");
                    string address = Console.ReadLine();
                    persiondetail.Address = address;
                    break;
                case 6:
                    Console.Write("Enter City to Update : ");
                    string city = Console.ReadLine();
                    persiondetail.City = city;
                    break;
                case 7:
                    Console.Write("Enter District to Update : ");
                    string district = Console.ReadLine();
                    persiondetail.District = district;
                    break;
                case 8:
                    Console.Write("Enter State to Update : ");
                    string state = Console.ReadLine();
                    persiondetail.State = state;
                    break;
                case 9:
                    Console.Write("Enter First Name to Update : ");
                    int zipcode = Convert.ToInt32(Console.ReadLine());
                    persiondetail.Zip = zipcode;
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
        public void DeleteContact(string uniqueName)
        {
            contactDetailDictionary.Remove(uniqueName);
        }

        public ContactDetails GetUsingByFirstName(string firstName)
        {
            foreach (var item in contactDetailDictionary)
            {
                if (item.Value.FirstName == firstName)
                {
                    return item.Value;
                }
            }
            return null;
        }
        public void DeleteContactByFirstName(string fName)
        {
            var objfName = GetUsingByFirstName(fName);
            contactDetailDictionary.Remove(objfName.UniqueName);
        }
        public void SearchContactUsingCityorState()
        {
            Console.WriteLine("\nEnter 1 to Search Contact Using City \n" +
                "Enter 2 to Search Contact Using State");
            int intput = Convert.ToInt32(Console.ReadLine());
            switch (intput)
            {
                case 1:
                    Console.Write("Enter City to Search Contact : ");
                    string city = Console.ReadLine();
                    var contacts = contactDetailDictionary.Where(detail => detail.Value.City == city);
                    Console.WriteLine("\n******************** Contacts in Address Book ********************");
                    if (!contacts.Any())
                    {
                        Console.WriteLine($"Contacts Not Available in Address Book of City {city}\n");
                        return;
                    }
                    foreach (var contact in contacts)
                    {
                        Console.Write("First Name is : " + contact.Value.FirstName + "\n");
                        Console.Write("Last Name is : " + contact.Value.LastName + "\n");
                        Console.Write("Mobile Number is : " + contact.Value.MobileNumber + "\n");
                        Console.Write("Email ID is : " + contact.Value.Email + "\n");
                        Console.Write("Address is : " + contact.Value.Address + "\n");
                        Console.Write("City is : " + contact.Value.City + "\n");
                        Console.Write("District is : " + contact.Value.District + "\n");
                        Console.Write("State is : " + contact.Value.State + "\n");
                        Console.Write("Zip Code is : " + contact.Value.Zip + "\n") ;
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;

                case 2:
                    Console.Write("Enter State to Search Contact : ");
                    string state = Console.ReadLine();
                    var contactState = contactDetailDictionary.Where(detail => detail.Value.State == state);
                    Console.WriteLine("\n******************** Contacts in Address Book ********************");
                    if (!contactState.Any())
                    {
                        Console.WriteLine($"Contacts Not Available in Address Book of State {state}\n");
                        return;
                    }
                    foreach (var contact in contactState)
                    {
                        Console.Write("First Name is : " + contact.Value.FirstName + "\n");
                        Console.Write("Last Name is : " + contact.Value.LastName + "\n");
                        Console.Write("Mobile Number is : " + contact.Value.MobileNumber + "\n");
                        Console.Write("Email ID is : " + contact.Value.Email + "\n");
                        Console.Write("Address is : " + contact.Value.Address + "\n");
                        Console.Write("City is : " + contact.Value.City + "\n");
                        Console.Write("District is : " + contact.Value.District + "\n");
                        Console.Write("State is : " + contact.Value.State + "\n");
                        Console.Write("Zip Code is : " + contact.Value.Zip + "\n");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
            }

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
