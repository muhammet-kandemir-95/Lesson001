namespace Lesson_001.Model.School
{
    public class Student
    {
        // Field
        public string Name = null;
        // Field
        public string Surname = null;
        // Field
        public int BirthYear = 0;

        // Constractor
        public Student(string name, string surname, int birthYear)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ApplicationException("Name must be filled!");
            }

            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new ApplicationException("Surname must be filled!");
            }

            if (birthYear <= 0)
            {
                throw new ApplicationException("Birth year must be greater than 0!");
            }

            this.Name = name;
            this.Surname = surname;
            this.BirthYear = birthYear;
        }
    }
}