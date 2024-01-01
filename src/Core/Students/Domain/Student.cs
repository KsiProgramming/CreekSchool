//-----------------------------------------------------------------------
// <copyright file="Student.cs" company="CreekSchool">
// Copyright (c) CreekSchool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Students
{
    public class Student
    {
        public Student(string firstName, string lastName, GenderType gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public GenderType Gender { get; }

        public string? Classroom { get; set; }
    }
}
