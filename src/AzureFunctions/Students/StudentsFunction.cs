namespace CreekSchool.Students.AzureFunctions
{
    using Microsoft.Azure.Functions.Worker;
    using Microsoft.Azure.Functions.Worker.Http;
    using System.Net;

    public class StudentsFunction
    {
        private readonly IStudentManager manager;

        public StudentsFunction(IStudentManager manager)
        {
            this.manager = manager;
        }

        [Function("FindStudents")]
        public async Task<HttpResponseData> FindStudents([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);

            var students = await this.manager.FindAsync(query: default);

            await response.WriteAsJsonAsync(students);

            return response;
        }
    }
}
