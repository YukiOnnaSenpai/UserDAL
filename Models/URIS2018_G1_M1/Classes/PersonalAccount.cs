using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace URISErrorUserDAL.Models
{
    public class PersonalAccount
    {
        [Key]
        public int? UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string ContactPhone { get; set; } 
        public bool Valid { get; set; }
        public short IsActive  { get; set; }
        public int Password { get; set; }
        public byte Salt { get; set; }

        public List<Address> Addresses { get; set; }
        public List<Email> Emails { get; set; }
        public CorporateAccount CorporateId { get; set; }
    }
}