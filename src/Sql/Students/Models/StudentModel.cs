namespace CreekSchool.Students.Sql
{
    public class StudentModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int SexId { get; set; }

        public SexModel Sex { get; set; }
    }
}
