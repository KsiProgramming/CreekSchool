//-----------------------------------------------------------------------
// <copyright file="StudentManager.cs" company="CreekSchool">
// Copyright (c) CreekSchool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Students
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class StudentManager : IStudentManager
    {
        private readonly IStudentRepository repository;

        public StudentManager(IStudentRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddAsync(IReadOnlyCollection<Student> students)
        {
            await this.repository.AddAsync(students);
        }

        public async Task<IReadOnlyCollection<Student>> FindAsync(StudentQuery query)
        {
            var students = await this.repository.FindAsync(query);

            return students;
        }
    }
}
