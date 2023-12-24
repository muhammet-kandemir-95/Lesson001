#pragma warning disable 8625

using Lesson_001.Model.School;

namespace Lesson_001
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class cls1 = new Class(
                "A-10", 
                new Student("Muhammet", "Kandemir", 1995), 
                new Student("Hamza", "Kandemir", 1999), 
                new Student("Ömer", "Kandemir", 2000), 
                new Student("Mert", "Şanli", 2000));

            cls1.Print();
        }
    }
}