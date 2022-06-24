using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Datas
{
    public class TeacherDbContext
    {
        public int IdTeacher { get; set; }
        public string NameTeacher { get; set; }
        public string Gmail { get; set; }
        public string Phone { get; set; }
        public bool Gender { get; set; }
        public DateTime Birth { get; set; }
        public int IdAccount { get; set; }

        //relationship
        public AccountDbContext AccountDbContext { get; set; }
    }
}
