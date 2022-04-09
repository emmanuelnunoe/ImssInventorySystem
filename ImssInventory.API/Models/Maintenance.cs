using System.ComponentModel.DataAnnotations.Schema;
using ImssInventory.API.Models.Enums;

namespace ImssInventory.API.Models
{
    public class Maintenance
    {
        public int MaintenanceId { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public DateTime MaintenanceFinishDate { get; set; }
        [ForeignKey("CheckListId")]
        public int? CheckListId { get; set; }
        public CheckList? CheckList { get; set; }

        [ForeignKey("ITUserId")]
        public int? ITUserId { get; set; }
        public ITUser? ITUser { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Comments { get; set; }
        public MaintenanceStatus Status { get; set; }
    }
}
