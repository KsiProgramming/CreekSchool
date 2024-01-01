//-----------------------------------------------------------------------
// <copyright file="CreekSchoolDbContext.cs" company="CreekSchool">
// Copyright (c) CreekSchool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Sql
{
    using CreekSchool.Sql.Configurations;

    public class CreekSchoolDbContext : DbContext
    {
        public CreekSchoolDbContext(DbContextOptions<CreekSchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<StudentModel> Students { get; set; }

        public DbSet<SexModel> Sexs { get; set; }

        public DbSet<ClassroomModel> Classrooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyDataModulesConfiguration();
        }
    }
}
