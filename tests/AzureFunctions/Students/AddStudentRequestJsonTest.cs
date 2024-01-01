//-----------------------------------------------------------------------
// <copyright file="AddStudentRequestJsonTest.cs" company="CreekSchool">
// Copyright (c) CreekSchool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Students.AzureFunctions.Tests
{
    public class AddStudentRequestJsonTest
    {
        [Fact]
        public void Constructor()
        {
            var request = new AddStudentRequestJson(
                firstName: "First Name",
                lastName: "Last Name",
                gender: 1);

            request.FirstName.Should().Be("First Name");
            request.LastName.Should().Be("Last Name");
            request.Gender.Should().Be(1);
        }
    }
}
