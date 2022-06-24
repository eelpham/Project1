using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Datas
{
    public class AdminDbContext
    {
        public int IdAdmin { get; set; }
        public string NameAdmin { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
        public int IdAccount { get; set; }


        //relationship
        public AccountDbContext AccountDbContext { get; set; }
    }
}
