using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace URISErrorUserDAL.Models
{
    public class CorporateAccount
    {
        [Key]
        public int? CorporateId { get; set; }
        public string Name { get; set; }
        public string BusinessType { get; set; }
        public int PIB { get; set; }
        public string ContactPhone { get; set; }
        public bool Valid { get; set; }
        public short IsActive { get; set; }
        public byte[] Password { get; set; }
        public byte[] Salt { get; set; }

        public List<Address> Addresses { get; set; }
        public List<Email> Emails { get; set; }
        public List<PersonalAccount> UsersBound { get; set; }
    }
}