

using System.Runtime.CompilerServices;

namespace CreekSchool.Students.Sql
{
    public class StudentRepository : IStudentRepository
    {
        private readonly CreekSchoolDbContext context;

        public StudentRepository(CreekSchoolDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(IReadOnlyCollection<Student> students)
        {
            var studentsToAdd = students.Select(MapStudentModel);

            await this.context.AddRangeAsync(studentsToAdd);
            await this.context.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<Student>> FindAsync(StudentQuery query)
        {
            var students = from student in this.context.Students.AsNoTracking()
                           select student;

            if (query.LastName != null)
            {
                students = students.Where(s => s.LastName.Equals(query.LastName));
            }

            if (query.FirstName != null)
            {
                students = students.Where(s => s.FirstName.Equals(query.FirstName));
            }

            var resutl = students
                .Include(s => s.Sex)
                .Include(s => s.Classroom)
                .Select(MapStudent)
                .ToArray();

            return resutl;
        }

        private static Student MapStudent(StudentModel model)
        {
            return new Student(
                firstName: model.FirstName,
                lastName: model.LastName,
                gender: (GenderType)model.Sex.Id)
            {
                Classroom = model.Classroom?.Name,
            };
        }

        private async Task<StudentModel> MapStudentModel(Student student)
        {
            return new StudentModel()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                SexId = (int)student.Gender,
            };
        }
    }
}
