using System.ComponentModel.DataAnnotations;

namespace URISErrorUserDAL.Models
{
    public class Email
    {
        [Key]
        public int? EmailId { get; set; }
        public PersonalAccount UserId { get; set; }
        public CorporateAccount CorporateId { get; set; }
        public byte IsPrimary { get; set; }
        public short IsActive { get; set; }
        public string EmailAddress { get; set; }

        public string  Token { get; set; }
    }
}