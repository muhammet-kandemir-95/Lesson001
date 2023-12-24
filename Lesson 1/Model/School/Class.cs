namespace Lesson_001.Model.School
{
    class Class
    {
        // Field
        public string Name = null;
        // Field
        public Student Student1 = null;
        // Field
        public Student Student2 = null;
        // Field
        public Student Student3 = null;
        // Field
        public Student Student4 = null;

        // Constructor
        public Class(string name, Student student1, Student student2, Student student3, Student student4)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ApplicationException("Name must be filled!");
            }

            if (student1 == null)
            {
                throw new ApplicationException("Student1 must have an instance!");
            }

            if (student2 == null)
            {
                throw new ApplicationException("Student2 must have an instance!");
            }

            if (student3 == null)
            {
                throw new ApplicationException("Student3 must have an instance!");
            }

            if (student4 == null)
            {
                throw new ApplicationException("Student4 must have an instance!");
            }

            this.Name = name;
            this.Student1 = student1;
            this.Student2 = student2;
            this.Student3 = student3;
            this.Student4 = student4;
        }
    
        // Method
        private void printInfo(string leftText, string rightText, bool doubleQuote, bool space)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            if (rightText == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (space)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            if (space == true)
            {
                Console.Write("> ");
            }

            Console.Write(leftText + " : ");

            if (doubleQuote)
            {
                Console.Write("\"" + rightText + "\"");
            }
            else
            {
                Console.Write(rightText);
            }

            Console.WriteLine();
        }

        private void printStudent(int studentNumber, Student student)
        {
            this.printInfo("Student " + studentNumber + " Information", "", false, false);
            this.printInfo("Name", student.Name, true, true);
            this.printInfo("Surname", student.Surname, true, true);
            this.printInfo("Birth Year", student.BirthYear.ToString(), false, true);
        }

        // Method
        public void Print()
        {
            this.printInfo("Class Name", this.Name, true, false);

            this.printStudent(1, this.Student1);
            this.printStudent(2, this.Student2);
            this.printStudent(3, this.Student3);
            this.printStudent(4, this.Student4);
        }
    }
}