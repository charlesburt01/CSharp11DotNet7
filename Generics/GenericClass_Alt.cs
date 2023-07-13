public class GenericClass<T>
{
    private T genericMemberVariable;

    public GenericClass(T value)
    {
        genericMemberVariable = value;
    }

    public T GenericMethod()
    {
        return genericMemberVariable;
    }
}
class Program
{
    static void Main(string[] args)
    {
        GenericClass<int> intGenericClass = new GenericClass<int>(10);
        int val = intGenericClass.GenericMethod(); // val will be 10

        GenericClass<string> stringGenericClass = new GenericClass<string>("Hello Generics");
        string str = stringGenericClass.GenericMethod(); // str will be "Hello Generics"

        Console.WriteLine(val);
        Console.WriteLine(str);
        Console.ReadKey();
    }
}
