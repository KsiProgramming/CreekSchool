namespace CreekSchool.Students
{
    public class Student
    {
        public Student(string firstName, string lastName, GenderType gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public GenderType Gender { get; set; }
    }
}
