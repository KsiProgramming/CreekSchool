

namespace CreekSchool.Sql
{
    using CreekSchool.Students;
    using CreekSchool.Students.Sql;
    using Microsoft.Extensions.DependencyInjection;

    public static class CompositionRoot
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddDbContext<CreekSchoolDbContext>(options =>
            options.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=CreekSchoolDb;Trusted_Connection=True;"));

            services.AddScoped<IStudentRepository, StudentRepository>();

            return services;
        }
    }
}
