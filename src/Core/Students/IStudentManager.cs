//-----------------------------------------------------------------------
// <copyright file="IStudentManager.cs" company="CreekSchool">
// Copyright (c) CreekSchool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Students
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IStudentManager
    {
        Task AddAsync(IReadOnlyCollection<Student> students);

        Task<IReadOnlyCollection<Student>> FindAsync(StudentQuery query);
    }
}