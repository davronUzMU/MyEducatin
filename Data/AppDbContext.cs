using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyEducatin.Models;

namespace MyEducatin.Data
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        protected readonly IConfiguration _configuration;
        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
          : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("WebApiDatabase"));
            //base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryImage> CategoriesImage { get; set; }
        public DbSet<Course>Courses { get; set; }
        public DbSet<Img> Img { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<StudentResult> StudentResults { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectVideo> SubjectVideos { get; set; }
        public DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Course>().
                HasOne(C=>C.Category)
                .WithMany(cat => cat.Courses) 
                .HasForeignKey(c => c.CategoryId) 
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Subject>().
                  HasOne(V => V.Course).
                  WithMany(Course => Course.Subjects).
                  HasForeignKey(F => F.CourseId);
            modelBuilder.Entity<Test>().
                HasOne(B=>B.Subject).
                WithMany(N=>N.tests).
                HasForeignKey(J=>J.SubjectId);
            modelBuilder.Entity<Book>().
                HasOne(K => K.Subject).
                WithMany(H => H.books).
                HasForeignKey(w => w.SubjectId);
            modelBuilder.Entity<Question>().
                HasOne(Q => Q.Test).
                WithMany(T => T.Questions).
                HasForeignKey(DD => DD.TestId);
            modelBuilder.Entity<Answer>().
                HasOne(S=>S.Question).
                WithMany(Y=>Y.Answers).
                HasForeignKey(O=>O.QuestionId);
            modelBuilder.Entity<Student>().
                HasOne(I => I.StudentGroup).
                WithMany(N => N.Students).
                HasForeignKey(H => H.studentGroupId);
            modelBuilder.Entity<StudentResult>().
                HasOne(M=>M.student).
                WithMany(K=>K.StudentResults).
                HasForeignKey(J=>J.StudentId);
            modelBuilder.Entity<SubjectVideo>().
                HasOne(L=>L.Subject).
                WithMany(K=>K.SubjectVideo).
                HasForeignKey(J=>J.SubjectId);

            base.OnModelCreating(modelBuilder); 

        }
    }
}
