namespace Test_Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        // Foreign key
        public int IdPerson { get; set; }
        public Person? Person { get; set; }  // Relación con Person

    }
}
