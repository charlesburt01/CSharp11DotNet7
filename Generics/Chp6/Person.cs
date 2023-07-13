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