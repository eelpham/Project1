using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Datas
{
    public class AccountDbContext
    {
        public int IdAccount { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Gmail { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public DateTime CreateDate { get; set; }

        public AdminDbContext AdminDbContext { get; set; }
        public StudentDbContext StudentDbContext { get; set; }
        public TeacherDbContext TeacherDbContext { get; set; }
    }
    

}
