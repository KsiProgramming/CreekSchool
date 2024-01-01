//-----------------------------------------------------------------------
// <copyright file="CompositionRootTest.cs" company="CreekSchool">
// Copyright (c) CreekSchool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Tests
{
    using CreekSchool.Students;
    using Microsoft.Extensions.DependencyInjection;

    public class CompositionRootTest
    {
        [Fact]
        public void AddCoreServices_ShouldRegisterStudentManager()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddCoreServices();

            var registration = serviceCollection.Single(descriptor =>
                descriptor.ServiceType == typeof(IStudentManager) &&
                descriptor.ImplementationType == typeof(StudentManager));

            registration.ImplementationType.Should().Be(typeof(StudentManager));
        }
    }
}
