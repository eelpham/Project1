using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Datas
{
    public class ProjectDbContext: DbContext
    {
        public ProjectDbContext(DbContextOptions options) 
            : base(options) 
        {
        }
        public DbSet<AdminDbContext> Admins { get; set; }
        public DbSet<AccountDbContext> Accounts { get; set; }
        public DbSet<StudentDbContext> Students { get; set; }
        public DbSet<ClassDbContext> Classes { get; set; }
        public DbSet<TeacherDbContext> Teachers { get; set; }
        public DbSet<ClassdetailDbContext> ClassDetails { get; set; }
        public DbSet<SubjectDbContext> Subjects { get; set; }
        public DbSet<TestDbContext> Tests { get; set; }
        public DbSet<ScoreDbContext> Scores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminDbContext>(e =>
            {
                e.ToTable("Admin");
                e.HasKey(ad => ad.IdAdmin);
                e.Property(ad => ad.NameAdmin)
                 .IsRequired();
                e.Property(ad => ad.Phone)
                 .HasMaxLength(10);

                e.HasOne(ad => ad.AccountDbContext)
                .WithOne(ad => ad.AdminDbContext)
                .HasForeignKey<AdminDbContext>(ad => ad.IdAccount)
                .HasConstraintName("fk_admin_account");
            });

            modelBuilder.Entity<AccountDbContext>(e =>
            {
                e.ToTable("Account");
                e.HasKey(ac => ac.IdAccount);
                e.Property(ac => ac.User)
                 .IsRequired()
                 .HasMaxLength(15);
                e.Property(ac => ac.Password)
                 .IsRequired()
                 .HasMaxLength(15);
                e.Property(ac => ac.Gmail)
                 .IsRequired();
                e.Property(ac => ac.Phone)
                 .IsRequired()
                 .HasMaxLength(10);
                e.Property(ac => ac.CreateDate)
                 .HasDefaultValueSql("getutcdate()");

            });
            modelBuilder.Entity<ClassDbContext>(e =>
            {
                e.ToTable("Class");
                e.HasKey(cl => cl.IdClass);
                e.Property(cl => cl.NameClass)
                 .IsRequired();
                e.Property(cl => cl.Semester)
                .IsRequired();



                e.HasOne(su => su.SubjectDbContext)
                .WithMany(cl => cl.Classes)
                .HasForeignKey(cl => cl.IdSubject)
                .HasConstraintName("FK_Class_Subject");

            });

            modelBuilder.Entity<StudentDbContext>(e =>
            {

                e.ToTable("Student");
                e.HasKey(st => st.IdStudent);
                e.Property(st => st.NameStudent)
                 .IsRequired();
                e.Property(st => st.Gmail)
                 .IsRequired();
                e.Property(st => st.Phone)
                 .IsRequired();

                e.HasOne(ad => ad.AccountDbContext)
                .WithOne(st => st.StudentDbContext)
                .HasForeignKey<StudentDbContext>(ad => ad.IdAccount)
                .HasConstraintName("FK_Student_account");

            });

            modelBuilder.Entity<TeacherDbContext>(e =>
            {
                e.ToTable("Teacher");
                e.HasKey(te => te.IdTeacher);
                e.Property(te => te.NameTeacher)
                 .IsRequired();
                e.Property(te => te.Gmail)
                .IsRequired();
                e.Property(te => te.Phone)
                 .IsRequired()
                 .HasMaxLength(10);

                e.HasOne(ac => ac.AccountDbContext)
                .WithOne(te => te.TeacherDbContext)
                .HasForeignKey<TeacherDbContext>(te => te.IdAccount)
                .HasConstraintName("FK_Teacher_Account");

            });

            modelBuilder.Entity<ClassdetailDbContext>(e =>
            {
                e.ToTable("ClassDetail");
                e.HasKey(cd => cd.IdClassDetail);
                e.Property(cd => cd.PasswordClass)
                 .IsRequired()
                 .HasMaxLength(10);
                e.Property(cd => cd.Teacher)
                .IsRequired();
                e.Property(cd => cd.Lesson)
                .IsRequired();

                e.HasOne(cl => cl.ClassDbContext)
                .WithOne(cd => cd.ClassDetailDbContext)
                .HasForeignKey<ClassdetailDbContext>(cl => cl.IdClass)
                .HasConstraintName("FK_Class_Classdetail");
            });

            modelBuilder.Entity<SubjectDbContext>(e =>
            {
                e.ToTable("Subject");
                e.HasKey(cd => cd.IdSubject);
                e.Property(cd => cd.NameSubject)
                 .IsRequired();
            });

            modelBuilder.Entity<TestDbContext>(e =>
            {
                e.ToTable("Test");
                e.HasKey(te => te.IdTest);
                e.Property(te => te.NameTest)
                .IsRequired();
                e.Property(te => te.CreateDate)
                 .HasDefaultValueSql("getutcdate()");

                e.HasOne(su => su.SubjectDbContext)
               .WithMany(cl => cl.Tests)
               .HasForeignKey(cl => cl.IdSubject)
               .HasConstraintName("FK_Test_Subject");

            });

            modelBuilder.Entity<ScoreDbContext>(e =>
            {
                e.ToTable("Scorelearning");
                e.HasKey(sc => sc.IdScore);
                e.Property(sc => sc.UpdateDate)
                 .HasDefaultValueSql("getutcdate()");

                e.HasOne(st => st.StudentDbContext)
                .WithOne(sc => sc.ScoreDbContext)
                .HasForeignKey<ScoreDbContext>(sc => sc.IdStudent)
                .HasConstraintName("FK_Score_Student");

                e.HasOne<SubjectDbContext>(su => su.SubjectDbContext)
              .WithMany(cs => cs.Scores)
              .HasForeignKey(cl => cl.IdSubject)
              .HasConstraintName("FK_Score_Subject");

            });
        }
    }
     
}
