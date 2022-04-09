namespace ImssInventory.API.Models
{
    public class PasswordReset
    {
        public int PasswordResetId { get; set; }
        public string Email { get; set;} = string.Empty!;    
        public string Token { get; set; } = string.Empty!;
    }
}
