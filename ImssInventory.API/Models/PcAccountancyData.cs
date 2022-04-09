using System.ComponentModel.DataAnnotations;

namespace ImssInventory.API.Models
{
    public class PcAccountancyData
    {
        public int PcAccountancyDataId { get; set; }
        [Required, MaxLength(30)]
        public string SerialNumber { get; set; } = null!;
        public string? CostsCenter { get; set; }
        public int? AdquisitionYear { get; set; }
    }
}
