namespace CreekSchool.Students.Tests
{
    public class StudentTest
    {
        [Fact]
        public void Constructor()
        {
            var student = new Student(
                firstName: "FirstName",
                lastName: "LastName",
                gender: GenderType.Male);

            student.FirstName.Should().Be("FirstName");
            student.LastName.Should().Be("LastName");
            student.Gender.Should().Be(GenderType.Male);
            student.Classroom.Should().BeNull();
        }

        [Fact]
        public void Classroom_ValueChanged()
        {
            var student = new Student(
                firstName: default!,
                lastName: default!,
                gender: default)
            {
                Classroom = "A1",
            };

            student.Classroom.Should().Be("A1");
        }
    }
}
