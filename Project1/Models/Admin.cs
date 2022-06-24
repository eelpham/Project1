namespace Project1.Models
{
    public class Admin
    {
        public string IdAdmin { get; set; }
        public string NameAdmin { get; set; }

        public string Phone { get; set; }

        public Gender Gender { get; set; }

        public int IdAccount { get; set; }
    }
    public enum Gender
    {
        male, female
    }
}
