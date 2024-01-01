//-----------------------------------------------------------------------
// <copyright file="CompositionRoot.cs" company="CreekSchool">
// Copyright (c) CreekSchool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Sql
{
    using CreekSchool.Students;
    using CreekSchool.Students.Sql;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class CompositionRoot
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration config)
        {
            if (string.IsNullOrWhiteSpace(config["CREEK_SCHOOL_SQL_CONNECTIONSTRING"]))
            {
                throw new InvalidOperationException("The Creek school connectionstring must be specified. (Missing setting: 'CREEK_SCHOOL_SQL_CONNECTIONSTRING')");
            }

            services.AddDbContext<CreekSchoolDbContext>(options =>
            options.UseSqlServer(config["CREEK_SCHOOL_SQL_CONNECTIONSTRING"]));

            services.AddScoped<IStudentRepository, StudentRepository>();

            return services;
        }
    }
}
