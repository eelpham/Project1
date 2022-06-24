using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Datas
{
    public class ClassdetailDbContext
    {
        public int IdClassDetail { get; set; }
        public string PasswordClass { get; set; }
        public string Teacher { get; set; }
        public string Lesson { get; set; }
        public string StudyTime { get; set; }
        public string Schedule { get; set; }
        public string Description { get; set; }
        public int IdClass { get; set; }


        
        public ClassDbContext ClassDbContext { get; set; }
    }
}
