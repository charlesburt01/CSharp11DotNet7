public class TwoGenericClass<T1, T2>
{
    private T1 _firstValue;
    private T2 _secondValue;

    public TwoGenericClass(T1 first, T2 second)
    {
        _firstValue = first;
        _secondValue = second;
    }

    public T1 GetFirstValue()
    {
        return _firstValue;
    }

    public T2 GetSecondValue()
    {
        return _secondValue;
    }
}

class Program
{
    static void Main(string[] args)
    {
        TwoGenericClass<int, string> myClass = new TwoGenericClass<int, string>(10, "Hello Generics");
        int val = myClass.GetFirstValue(); // val will be 10
        string str = myClass.GetSecondValue(); // str will be "Hello Generics"

        Console.WriteLine(val);
        Console.WriteLine(str);
        Console.ReadKey();
    }
}

