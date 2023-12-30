//-----------------------------------------------------------------------
// <copyright file="IStudentManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Students
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IStudentManager
    {
        Task<IReadOnlyCollection<Student>> FindAsync(StudentQuery query);
    }
}