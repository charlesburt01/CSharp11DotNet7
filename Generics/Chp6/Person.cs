public class Person : object
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public List<Person> Children = new();

    public void WriteToConsole()
    {
        Console.WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }
}
/*Person harry = new()
{
    Name = "Harry",
    DateOfBirth = new(year: 2001, month: 3, day: 25)
};

List<Person> People = new();*/

/*Person bob = new()
{
    Name = "bob",
    DateOfBirth = new DateTime(1965, 12, 22)
};

bob.Children.Add(new Person { Name = "Alfred" }); //C# 3.0 and later
bob.Children.Add(new() { Name = "Zoe" }); // C#9.0 and later

Console.WriteLine($"{bob.Name} has {bob.Children.Count} children");

for (int i = 0; i < bob.Children.Count; i++)
{
    Console.WriteLine($"> {bob.Children[i].Name}");
}*/