//-----------------------------------------------------------------------
// <copyright file="StudentModel.cs" company="CreekSchool">
// Copyright (c) CreekSchool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Sql
{
    public class StudentModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int SexId { get; set; }

        public SexModel Sex { get; set; }

        public int? ClassroomId { get; set; }

        public ClassroomModel? Classroom { get; set; }
    }
}
