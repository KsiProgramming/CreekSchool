namespace CreekSchool.Students
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IStudentRepository
    {
        Task AddAsync(IReadOnlyCollection<Student> students);

        Task<IReadOnlyCollection<Student>> FindAsync(StudentQuery query);
    }
}
