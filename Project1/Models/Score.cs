namespace Project1.Models
{
    public class Score
    {
        public float ScoreDiligence { get; set; }
        public float ScoreOral { get; set; }
        public float Score15min { get; set; }
        public float ScoreCorfficient2 { get; set; }
        public float ScoreCorfficient3 { get; set; }
        public float MediumScore { get; set; }
        public float TotalScore { get; set; }
        public string Result { get; set; }
        public DateTime UpdateDate { get; set; }
        public string IdStudent { get; set; }
        public string IdSubject { get; set; }
    }
}
