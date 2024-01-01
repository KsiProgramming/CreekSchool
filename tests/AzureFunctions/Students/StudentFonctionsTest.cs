//-----------------------------------------------------------------------
// <copyright file="StudentFonctionsTest.cs" company="CreekSchool">
// Copyright (c) CreekSchool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Students.AzureFunctions.Tests
{
    using System.Net;
    using Azure.Core.Serialization;
    using Microsoft.Azure.Functions.Worker;
    using Microsoft.Azure.Functions.Worker.Http;
    using Microsoft.Extensions.Options;
    using Moq;

    public class StudentFonctionsTest
    {
        [Fact]
        public async Task AddStudent()
        {
            var requestBody = Mock.Of<Stream>();

            var studentToAdd = new AddStudentRequestJson(
                firstName: "The first name.",
                lastName: "The last name.",
                gender: 1);

            var manager = new Mock<IStudentManager>(MockBehavior.Strict);
            manager
                .Setup(m => m.AddAsync(It.IsAny<IReadOnlyCollection<Student>>()))
                .Callback((IReadOnlyCollection<Student> students) =>
                {
                    students.Should().HaveCount(1);
                    students.ElementAt(0).FirstName.Should().Be("The first name.");
                    students.ElementAt(0).LastName.Should().Be("The last name.");
                    students.ElementAt(0).Gender.Should().Be(GenderType.Female);
                })
                .Returns(Task.CompletedTask);

            var serializer = new Mock<ObjectSerializer>(MockBehavior.Strict);
            serializer
                .Setup(s => s.DeserializeAsync(requestBody, typeof(AddStudentRequestJson), CancellationToken.None))
                .ReturnsAsync(studentToAdd);

            var workerOptions = Options.Create(new WorkerOptions()
            {
                Serializer = serializer.Object,
            });

            var serviceProvider = new Mock<IServiceProvider>(MockBehavior.Strict);
            serviceProvider
                .Setup(s => s.GetService(typeof(IOptions<WorkerOptions>)))
                .Returns(workerOptions);

            var functionContext = new Mock<FunctionContext>(MockBehavior.Strict);
            functionContext
                .Setup(c => c.InstanceServices)
                .Returns(serviceProvider.Object);

            var response = new Mock<HttpResponseData>(MockBehavior.Strict, functionContext.Object);
            response.SetupSet(r => r.StatusCode = HttpStatusCode.OK);

            var request = new Mock<HttpRequestData>(MockBehavior.Strict, functionContext.Object);
            request
                .Setup(r => r.Body)
                .Returns(requestBody);
            request
                .Setup(r => r.CreateResponse())
                .Returns(response.Object);

            var functions = new StudentsFunction(manager: manager.Object);
            await functions.AddStudent(request.Object);

            request.Verify();
            manager.Verify();
        }
    }
}
