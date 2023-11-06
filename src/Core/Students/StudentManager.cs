namespace CreekSchool.Students
{
    public class StudentManager
    {
        private readonly IStudentRepository repository;

        public StudentManager(IStudentRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IReadOnlyCollection<Student>> Find(StudentQuery query)
        {
            var students = await this.repository.FindAsync(query);

            return students;
        }
    }
}
