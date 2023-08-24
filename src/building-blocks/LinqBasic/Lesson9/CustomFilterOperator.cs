using LinqBasic.Lesson8;

namespace LinqBasic.Lesson9;

public class CustomFilterOperator
{
    public static void Run()
    {
        var result1 = Students()
            .Filter(s => s.Age > 12);

        foreach (var student in result1)
        {
            Console.WriteLine(student.StudentName);
        }

        
        var result2 = Students()
            .FilterYield(s => s.Age > 12);

        foreach (var student in result2)
        {
            Console.WriteLine(student.StudentName);
        }
    }
    
    private static IList<Student> Students()
    {
        return new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };
    }
}