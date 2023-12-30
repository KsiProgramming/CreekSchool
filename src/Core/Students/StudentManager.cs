

namespace CreekSchool.Students
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class StudentManager : IStudentManager
    {
        //private readonly IStudentRepository repository;

        public StudentManager()
        {
            //this.repository = repository;
        }

        public async Task<IReadOnlyCollection<Student>> FindAsync(StudentQuery query)
        {
            //var students = await this.repository.FindAsync(query);
            List<Student> students = new List<Student>
            {
                new Student("John", "Doe", GenderType.Male),
                new Student("Jane", "Smith", GenderType.Female),
                new Student("Mike", "Johnson", GenderType.Male),
                new Student("Emily", "Williams", GenderType.Female),
                new Student("Alex", "Brown", GenderType.Male),
                new Student("Chris", "Taylor", GenderType.Male),
                new Student("Sara", "Miller", GenderType.Female),
                new Student("Daniel", "Clark", GenderType.Male),
                new Student("Grace", "Anderson", GenderType.Female),
                new Student("Jordan", "Lee", GenderType.Female)
            };
            return students;
        }
    }
}
