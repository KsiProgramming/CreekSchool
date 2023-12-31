//-----------------------------------------------------------------------
// <copyright file="StudentsFunction.cs" company="CreekSchool">
// Copyright (c) CreekSchool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CreekSchool.Students.AzureFunctions
{
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.Azure.Functions.Worker;
    using Microsoft.Azure.Functions.Worker.Http;

    public class StudentsFunction
    {
        private readonly IStudentManager manager;

        public StudentsFunction(IStudentManager manager)
        {
            this.manager = manager;
        }

        [Function("AddStudent")]
        public async Task<HttpResponseData> AddStudent([HttpTrigger(AuthorizationLevel.Anonymous, "Post", Route = "api/AddStudent")] HttpRequestData req)
        {
            var jsonStudentToAdd = await req.ReadFromJsonAsync<AddStudentRequestJson>();

            var students = new Student[]
            {
                new Student(
                    firstName: jsonStudentToAdd!.FirstName,
                    lastName: jsonStudentToAdd.LastName,
                    gender: (GenderType)jsonStudentToAdd.Gender),
            };

            await this.manager.AddAsync(students);

            return req.CreateResponse(HttpStatusCode.OK);
        }

        [Function("FindStudents")]
        public async Task<HttpResponseData> FindStudents([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "api/FindStudents")] HttpRequestData req)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);

            var query = new StudentQuery();
            var students = await this.manager.FindAsync(query: query);

            await response.WriteAsJsonAsync(students);

            return response;
        }
    }
}
