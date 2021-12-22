namespace ImssInventory.API.Models
{
    public class Computer
    {

        public int Id { get; set; }
        public string Brand { get; set; }
        public string  Model { get; set; }
        public string? SerialNumber { get; set; }
        public string? CostsCenter { get; set; }
        public int? AdquisitionYear { get; set; }
        public string? Host { get; set; }
        public string MacAddress { get; set; }
        public string IpAddress { get; set; }
        public byte IpType { get; set; }
        public string? Processor { get; set; }
        public string? Speed { get; set; }
        public string? HardDrive { get; set; }
        public byte? Ram { get; set; }
        public string? OperativeSystem { get; set; }
        public byte? TypeOs { get; set; }
        public string? ServicePack { get; set; }
        public byte? ActiveLicence { get; set; }
        public string? MonitorBrand { get; set; }
        public string? MonitorModel { get; set; }
        public string? MonitorSerialNumber { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }



    }
}
