namespace Test_Api.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? Address { get; set; }

        // Foreign keys
        public int IdCountry { get; set; }

        public int IdDepartment { get; set; }

        public int IdMunicipality { get; set; }
    }
}
