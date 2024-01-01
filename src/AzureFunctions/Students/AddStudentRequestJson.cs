//-----------------------------------------------------------------------
// <copyright file="AddStudentRequestJson.cs" company="CreekSchool">
// Copyright (c) CreekSchool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Students.AzureFunctions
{
    using System;
    using System.Text.Json.Serialization;

    public sealed class AddStudentRequestJson
    {
        public AddStudentRequestJson(string firstName, string lastName, int gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
        }

        [JsonPropertyName("firstname")]
        public string FirstName { get; }

        [JsonPropertyName("lastname")]
        public string LastName { get; }

        [JsonPropertyName("gender")]
        public int Gender { get; }
    }
}
