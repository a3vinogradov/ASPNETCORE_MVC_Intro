namespace Ch11_02_Sorting.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public List<User> Users { get; set; } = new();
    }
}
