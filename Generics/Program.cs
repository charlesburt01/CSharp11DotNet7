Person bob = new()
{
    Name = "bob",
    DateOfBirth = new DateTime(1965, 12, 22)
};

bob.Children.Add(new Person { Name = "Alfred" }); //C# 3.0 and later
bob.Children.Add(new() { Name = "Zoe" }); // C#9.0 and later

Console.WriteLine($"{bob.Name} has {bob.Children.Count} children");

for(int i = 0; i < bob.Children.Count; i++)
{
    Console.WriteLine($"> {bob.Children[i].Name}");
}