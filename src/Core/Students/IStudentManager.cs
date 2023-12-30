namespace CreekSchool.Students
{
    public interface IStudentManager
    {
        Task<IReadOnlyCollection<Student>> FindAsync(StudentQuery query);
    }
}