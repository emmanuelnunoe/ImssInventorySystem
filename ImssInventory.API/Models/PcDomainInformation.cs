using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ImssInventory.API.Utils;

namespace ImssInventory.API.Models
{
    public class PcDomainInformation
    {
        public int PcDomainInformationId { get; set; }
        public bool IsInDomain { get; set; }
        public string DomainAccount { get; set; } = null!;
        protected virtual string PasswordStored { get; set; } = null!;
        [Required, NotMapped]
        public string Password
        {
            get { return PasswordStored; }
            set { PasswordStored = Encrypt.GetSHA256(value); }
        }
        public string email { get; set; } = null!;
        public bool HasLynk { get; set; }
        public int UserPermissions { get; set; }
        public string? ReazonToBeAdministrator { get; set; }

        [ForeignKey("DomainId")]
        public int DomainId { get; set; }
        public Domain Domain { get; set; } = null!;
    }
}
