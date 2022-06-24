using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Datas
{
    public class ClassDbContext
    {
        public int IdClass { get; set; }
        public string NameClass { get; set; }
        public string Topic { get; set; }
        public string Semester { get; set; }
        public string Status { get; set; }
        public int IdSubject { get; set; }

        
        public ICollection<Student> Students { get; set; }
        public ClassDbContext()
        {
            Students = new List<Student>();
        }
        public ClassdetailDbContext ClassDetailDbContext { get; set; }
        public SubjectDbContext SubjectDbContext { get; set; }

    }
}
