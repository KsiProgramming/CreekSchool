using CreekSchool.Sql.Configurations;

namespace CreekSchool.Sql
{
    public class CreekSchoolDbContext : DbContext
    {
        public DbSet<StudentModel> Students { get; set; }

        public DbSet<SexModel> Sexs { get; set; }

        public DbSet<ClassroomModel> Classrooms { get; set; }

        //public DbSet<ProfessorModel> Professors { get; set; }

        //public DbSet<GradeModel> Grades { get; set; }

        public CreekSchoolDbContext(DbContextOptions<CreekSchoolDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyDataModulesConfiguration();
        }
    }
}
