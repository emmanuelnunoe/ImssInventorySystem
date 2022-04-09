using ImssInventory.API.Models.Enums;

namespace ImssInventory.API.Models
{
    public class CheckList
    {
        public int CheckListId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string RegisterNumber { get; set; } = null!;
        public CheckListStatus Status { get; set; }
        public string? Comments { get; set; }
        public List<Software>? SoftwareList { get; set; }
    }
}
