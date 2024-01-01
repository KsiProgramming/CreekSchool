namespace CreekSchool.Students.AzureFunctions
{
    using System;
    using System.Text.Json.Serialization;

    public sealed class AddStudentJson
    {
        public AddStudentJson(string firstName, string lastName, int gender)
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

        [JsonPropertyName("dateofbirth")]
        public DateOnly DateOfBirth { get; }
    }
}
