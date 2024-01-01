//-----------------------------------------------------------------------
// <copyright file="LevelModel.cs" company="CreekSchool">
// Copyright (c) CreekSchool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Sql
{
    public class LevelModel
    {
        public int Id { get; set; }

        public string Label { get; set; }

        public int ClassroomId { get; set; }

        public ClassroomModel Classroom { get; set; }
    }
}
