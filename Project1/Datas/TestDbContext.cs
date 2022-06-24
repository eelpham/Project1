using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Datas
{
    public class TestDbContext
    {
        public int IdTest { get; set; }
        public string NameTest { get; set; }
        public string Content { get; set; }
        public string Time { get; set; }
        public DateTime CreateDate { get; set; }
        public double Score { get; set; }
        public string Status { get; set; }
        public int IdSubject { get; set; }

        //relationship
        public SubjectDbContext SubjectDbContext { get; set; }
    }
}
