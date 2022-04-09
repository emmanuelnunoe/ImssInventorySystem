using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ImssInventory.API.Utils;

namespace ImssInventory.API.Models
{
    public class ITUser
    {
        public int ITUserID { get; set; }
        [Required]
        public string FullName { get; set; } = string.Empty!;
        [Required]
        public string UserName { get; set; } = string.Empty!;
        [Required]
        public string Email { get; set; } = string.Empty!;
        public DateTime EmailVerifiedAt { get; set; }

        protected virtual string PasswordStored { get; set; } = null!;
        [Required, NotMapped]
        public string Password {
            get { return PasswordStored; } 
            set { PasswordStored = Encrypt.GetSHA256(value); } 
        }


        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}
