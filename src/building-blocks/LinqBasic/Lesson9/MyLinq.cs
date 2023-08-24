namespace LinqBasic.Lesson9;

public static class MyLinq
{
    public static IEnumerable<T> FilterYield<T>(this IEnumerable<T> source,Func<T,bool> predicate)
    {
        //1. Read only
        //2. Forward only
        foreach (var item in source)
        {
            if (predicate(item))
            {
                yield return item;
            }
                
        }
    }
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> source,Func<T,bool> predicate)
    {
        var result = new List<T>();
        foreach (var item in source)
        {
            if (predicate(item))
            {
                result.Add(item);
            }
                
        }

        return result;
    }
}