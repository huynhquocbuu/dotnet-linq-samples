namespace LinqBasic.Lesson7;

public static class ActionFuncLesson
{
    public static void Run()
    {
        Action<int> myAction = new Action<int>(DoSomething);
        myAction(123);
        Func<int, double> myFunc = new Func<int, double>(CalculateSomething);
        Console.WriteLine(myFunc(5));
    }
    private static void DoSomething(int i)
    {
        Console.WriteLine(i);
    }

    private static double CalculateSomething(int i)
    {
        return (double)i / 2;
    }
}