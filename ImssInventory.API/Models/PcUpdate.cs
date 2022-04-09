using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImssInventory.API.Models
{
    public class PcUpdate
    {
        public int ID { get; set; }
        public DateTime UpdatedAt { get; set; }
        [Required, MinLength(10)]
        public string Reason { get; set; } =string.Empty!;
        [ForeignKey("ITUserID")]
        public int ITUserID { get; set; }
        public ITUser ITUser { get; set; }=null!;
        [Required]
        public string Changes { get; set; }=string.Empty!;

        [ForeignKey("ComputerId")]
        public int ComputerId { get; set; }
        public Computer Computer { get; set; } = null!;
    }
}
