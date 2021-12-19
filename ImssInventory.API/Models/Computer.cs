namespace ImssInventory.API.Models
{
    public class Computer
    {

        public int Id { get; set; }
        public string brand { get; set; }
        public string  model { get; set; }
        public string? serialNumber { get; set; }
        public string? costsCenter { get; set; }
        public int? adquisitionYear { get; set; }
        public string? host { get; set; }
        public string macAddress { get; set; }
        public string ipAddress { get; set; }
        public byte ipType { get; set; }
        public string? processor { get; set; }
        public string? speed { get; set; }
        public string? hardDrive { get; set; }
        public byte? ram { get; set; }
        public string? operativeSystem { get; set; }
        public byte? typeOs { get; set; }
        public string? servicePack { get; set; }
        public byte? activeLicence { get; set; }
        public string? monitorBrand { get; set; }
        public string? monitorModel { get; set; }
        public string? monitorSerialNumber { get; set; }
        public User user { get; set; }
        public int userId { get; set; }





    }
}
