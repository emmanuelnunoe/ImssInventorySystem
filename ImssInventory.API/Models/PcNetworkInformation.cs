using System.ComponentModel.DataAnnotations;

namespace ImssInventory.API.Models
{
    public class PcNetworkInformation
    {
        public int PcNetworkInformationId { get; set; }
        [Required, MaxLength(30)]
        public string Host { get; set; } = null!;
        [Required, MaxLength(16)]
        public string MacAddress { get; set; } = null!;
        [Required, MaxLength(12)]
        public string IpAddress { get; set; } = null!;
        public byte IpType { get; set; }
        public bool Internet { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
