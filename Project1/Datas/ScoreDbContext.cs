using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Datas
{
    public class ScoreDbContext
    {
        public int IdScore { get; set; }
        public double ScoreDiligence { get; set; }
        public double ScoreOral { get; set; }
        public double Score15min { get; set; }
        public double ScoreCorfficient2 { get; set; }
        public double ScoreCorfficient3 { get; set; }
        public double MediumScore { get; set; }
        public double TotalScore { get; set; }
        public string Result { get; set; }
        public DateTime UpdateDate { get; set; }
        public int IdStudent { get; set; }
        public int IdSubject { get; set; }

        //relationship
        public StudentDbContext StudentDbContext { get; set; }

        public SubjectDbContext SubjectDbContext { get; set; }
    }
}
