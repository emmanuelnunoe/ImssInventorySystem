using System.ComponentModel.DataAnnotations;
using ImssInventory.API.Models.Enums;

namespace ImssInventory.API.Models
{
    public class OS
    {
        public int OsId { get; set; }
        [MaxLength(10)]
        public string? OperativeSystem { get; set; }
        public OsEditions Edition { get; set; }
        public byte? TypeOs { get; set; }
        [MaxLength(10)]
        public string? ServicePack { get; set; }
        public byte? ActiveLicence { get; set; }
    }
}
