using System.ComponentModel.DataAnnotations;

namespace ImssInventory.API.Models
{
    public class Monitor
    {
        [Key]
        public int MonitorId { get; set; }
        [MaxLength(20)]
        public string? MonitorBrand { get; set; }
        [MaxLength(20)]
        public string? MonitorModel { get; set; }
        [MaxLength(20)]
        public string? MonitorSerialNumber { get; set; }
    }
}
