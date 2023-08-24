namespace LinqBasic.Lesson8;

public static class QueryAndMethodSyntax
{
    public static void RunQuerySyntax()
    {
        //LINQ Syntax
        var result = from s in Tuts()
                     where s.Contains("Tutorials")
                     select s;
        foreach (var s in result)
        {
            Console.WriteLine(s);
        }
        
        var teenAgerStudents = from s in Students()
            where s.Age > 12 && s.Age < 20
            select s;

        foreach (var s in teenAgerStudents)
        {
            Console.WriteLine(s.StudentName);
        }

    }

    public static void RunMethodSyntax()
    {
        var result = Tuts().Where(s => s.Contains("Tutorials"));

        foreach (var s in result)
        {
            Console.WriteLine(s);
        }
        var teenAgerStudents = Students()
            .Where(s => s.Age > 12 && s.Age < 20).ToList();
        foreach (var s in teenAgerStudents)
        {
            Console.WriteLine(s.StudentName);
        }
    }
    
    private static IList<String> Tuts()
    {
        return new List<string>() {
            "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C++",
            "MVC Tutorials" ,
            "Java"
        };
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