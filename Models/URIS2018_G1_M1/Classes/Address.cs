using System.ComponentModel.DataAnnotations;

namespace URISErrorUserDAL.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public PersonalAccount UserId { get; set; }
        public CorporateAccount CorporateId { get; set; }
        public short IsActive { get; set; }
        public bool IsValid { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
    }
}