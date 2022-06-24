using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Datas
{
    public class StudentDbContext
    {
        
        public int IdStudent { get; set; }
        public string NameStudent { get; set; }
        public string Gmail { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birth { get; set; }
        public int IdAccount { get; set; }

        
        public AccountDbContext AccountDbContext { get; set; }
        public ScoreDbContext ScoreDbContext { get; set; }
    }
}
