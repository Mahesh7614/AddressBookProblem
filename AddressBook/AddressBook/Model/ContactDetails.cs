using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Model
{
    internal class ContactDetails
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public long? MobileNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? State { get; set; }
        public int? Zip { get; set; }

    }
}
