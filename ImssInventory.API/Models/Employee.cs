using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ImssInventory.API.Models.Enums;

namespace ImssInventory.API.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [MaxLength(40), MinLength(3), Required]
        public string FirstName { get; set; } = null!;
        [MaxLength(40), MinLength(3), Required]
        public string LastName { get; set; } = null!;
        [MaxLength(40), MinLength(3), Required]
        public string? SecondSourname { get; set; }
        [Required]
        public string employeeNumber { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public int? PositionId{ get; set; } = null!;
        [ForeignKey("PositionId")]
        public Position? Position { get; set; }
        public Assignment Assignment { get; set; }
        public TypeOfContract TypeOfContract { get; set; }
        [Required]
        public byte Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
