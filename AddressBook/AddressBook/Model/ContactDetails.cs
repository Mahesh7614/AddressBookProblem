
namespace AddressBook.Model
{
    public class ContactDetails
    {
        public string? UniqueName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public long? MobileNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? State { get; set; }
        public int? Zip { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            ContactDetails details = obj as ContactDetails;

            return details.FirstName == FirstName || details.UniqueName == UniqueName || details.MobileNumber == MobileNumber || details.Email == Email;
        }
    }
}
