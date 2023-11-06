namespace CreekSchool.Students
{
    public interface IStudentRepository
    {
        Task<IReadOnlyCollection<Student>> FindAsync(StudentQuery query);
    }
}
