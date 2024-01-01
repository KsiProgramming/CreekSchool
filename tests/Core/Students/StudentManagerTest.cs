//-----------------------------------------------------------------------
// <copyright file="StudentManagerTest.cs" company="CreekSchool">
// Copyright (c) CreekSchool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Students.Tests
{
    using System.Collections.ObjectModel;
    using Moq;

    public class StudentManagerTest
    {
        [Fact]
        public async Task AddAsync()
        {
            var students = new Collection<Student>();

            var repository = new Mock<IStudentRepository>(MockBehavior.Strict);
            repository
                .Setup(r => r.AddAsync(students))
                .Returns(Task.CompletedTask);

            var manager = new StudentManager(repository: repository.Object);
            await manager.AddAsync(students);

            repository.VerifyAll();
        }

        [Fact]
        public async Task FindAsync()
        {
            var query = new StudentQuery();
            var students = Array.Empty<Student>();

            var repository = new Mock<IStudentRepository>(MockBehavior.Strict);
            repository
                .Setup(r => r.FindAsync(query))
                .ReturnsAsync(students);

            var manager = new StudentManager(repository: repository.Object);
            var foundStudents = await manager.FindAsync(query);

            foundStudents.Should().BeSameAs(students);

            repository.VerifyAll();
        }
    }
}
