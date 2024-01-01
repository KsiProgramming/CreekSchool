//-----------------------------------------------------------------------
// <copyright file="StudentQueryTest.cs" company="CreekSchool">
// Copyright (c) CreekSchool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Students.Tests
{
    public class StudentQueryTest
    {
        [Fact]
        public void Constructor()
        {
            var query = new StudentQuery();

            query.FirstName.Should().BeNull();
            query.LastName.Should().BeNull();
        }

        [Fact]
        public void FirstName_ValueChanged()
        {
            var query = new StudentQuery()
            {
                FirstName = "FirstName",
            };

            query.FirstName.Should().Be("FirstName");
        }

        [Fact]
        public void LastName_ValueChanged()
        {
            var query = new StudentQuery()
            {
                LastName = "LastName",
            };

            query.LastName.Should().Be("LastName");
        }
    }
}
