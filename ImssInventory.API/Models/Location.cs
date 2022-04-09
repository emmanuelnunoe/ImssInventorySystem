namespace ImssInventory.API.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; } = string.Empty!;
        public string? DelegationOrMunicipality { get; set; }
        public string? ImssProperty { get; set; }
        public string? Reference { get; set; }
        public string? PreyKey { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Floor { get; set; }
        public string? PhoneOrVPN { get; set; }
        public string? Extension { get; set; }
        public string? NormativeAddress { get; set; }
        public string? CoordinationOrUnity { get; set; }
        public string? DivisionAreaOrSpecialty { get; set; }
        public string? DepartmentOrService { get; set; }

    }
}
