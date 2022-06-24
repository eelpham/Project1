using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Datas
{
    public class SubjectDbContext
    {
        public int IdSubject { get; set; }
        public string NameSubject { get; set; }

        //relationship

        public ICollection<ClassDbContext> Classes { get; set; }

        public ICollection<TestDbContext> Tests { get; set; }

        public ICollection<ScoreDbContext> Scores { get; set; }
        public SubjectDbContext()
        {
            Classes = new List<ClassDbContext>();
            Tests = new List<TestDbContext>();
            Scores = new List<ScoreDbContext>();
        }
    }
}
