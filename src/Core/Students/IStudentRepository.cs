namespace CreekSchool.Students
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IStudentRepository
    {
        Task<IReadOnlyCollection<Student>> FindAsync(StudentQuery query);
    }
}
