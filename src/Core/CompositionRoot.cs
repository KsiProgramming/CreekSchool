namespace CreekSchool
{
    using CreekSchool.Students;
    using Microsoft.Extensions.DependencyInjection;

    public static class CompositionRoot
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentManager, StudentManager>();

            return services;
        }
    }
}
