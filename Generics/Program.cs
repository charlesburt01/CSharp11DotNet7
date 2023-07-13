//Generics
int[] myInt = 0,1,2;
string[] myString = "hello", "there", "mate";
double[] myDouble = 0.1m, 0.2m, 0.3m;

void PrintLoop<Thing>(Thing thing)
{
    foreach (Thing t in thing)
    {
        Console.WriteLine(t);
    }
}
/*
Person harry = new()
{
    Name = "Harry",
    DateOfBirth = new (year: 2001, month: 3, day: 25)
};

//non-generic lookup collection
System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");


int key = 2; // lookup the value that has 2 as its key

Console.WriteLine(format: "key {0} has value: {1}",
                    arg0: key,
                    arg1: lookupObject[key]);

Console.WriteLine(format: "key {0} has value: {1}",
                    arg0: harry,
                    arg1: lookupObject[harry]);

public class Person: object
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public List<Person> Children = new();
    public void WriteToConsole()
    {
        Console.WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }
}
*/