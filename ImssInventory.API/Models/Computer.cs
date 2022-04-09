using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ImssInventory.API.Models.Enums;

namespace ImssInventory.API.Models
{
    public class Computer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool Type { get; set; }
        [Required, MaxLength(20)]
        public string Brand { get; set; } = null!;
        [Required, MaxLength(20)]
        public string Model { get; set; } = null!;

        [ForeignKey("PcAccountancyDataId")]
        public int PcAccountancyDataId { get; set; }
        public PcAccountancyData PcAccountancyData { get; set; } = null!;

        [ForeignKey("PcNetworkInformationId")]
        public int PcNetworkInformationId { get; set; }
        public PcNetworkInformation PcNetworkInformation { get; set; } = null!;

        [MaxLength(5)]
        public string? Processor { get; set; }
        [MaxLength(5)]
        public string? Speed { get; set; }
        [MaxLength(6)]
        public string? HardDrive { get; set; }
        [MaxLength(6)]
        public byte? Ram { get; set; }

        [ForeignKey("OsId")]
        public int OsId { get; set; }
        public OS OS { get; set; } = null!;

        [ForeignKey("MonitorId")]
        public int MonitorId { get; set; }
        public Monitor Monitor { get; set; } = null!;
        
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;

        public PcStatus Status { get; set; }
    }
}
