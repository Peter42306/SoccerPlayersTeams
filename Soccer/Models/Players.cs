namespace Soccer.Models
{   
    public class Players
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Position { get; set; }

        // Implementation of a foreign key. Each player contain Id of his          
        public int TeamId { get; set; }
        public Teams? Team { get; set; }
    }
}
