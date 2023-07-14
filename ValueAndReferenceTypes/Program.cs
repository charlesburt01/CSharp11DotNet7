/*
 * Value Types

These include all the primitive data types and structures:

bool
byte
char
decimal
double
enum
float
int
long
sbyte
short
struct
uint
ulong
ushort
In addition to these, any struct types (including nullable value types and tuples) are also considered value types in C#.

Reference Types

These are some of the built-in reference types:

class
delegate
interface
object
string

Any arrays (int[], double[], MyClass[] etc.) and dynamic types are also considered reference types in C#.

These are broad categories, and you can define your own custom types (like classes, structures, interfaces, delegates) which will fall into one of these categories. Note that, in .NET, everything ultimately derives from System.Object, which is a reference type.
 */

//"Value types are the most primitive types, which means they must have a value"

//VALUE TYPE EXAMPLES
Console.WriteLine("VALUE TYPE EXAMPLES");
Console.WriteLine("These contain the actual values themselves, not a reference to a memory address that contains the values");
Console.WriteLine("-----------------------");
Console.WriteLine($"int = {default(int)}");
Console.WriteLine($"float = {default(float)}");
Console.WriteLine($"double = {default(double)}");
Console.WriteLine($"bool = {default(bool)}");
Console.WriteLine($"char = {default(char)}"); // likely string empty
Console.WriteLine($"byte = {default(byte)}");
Console.WriteLine("-----------------------");

//REFERENCE TYPE EXAMPLES
Console.WriteLine("REFERENCE TYPE EXAMPLE");
Console.WriteLine("NULL is the default value of all reference types, as reference means a memory address, which can contain nothing");
Console.WriteLine("-----------------------");
Console.WriteLine($"string = {default(string)}");
Console.WriteLine($"int[] = {default(int[])}");
Console.WriteLine("-----------------------");


//Playing around
Console.WriteLine("Playing with value types-------:");
int x = 10;
Console.WriteLine($"x = {x}");
Console.WriteLine($"running x = default");
x = default;
Console.WriteLine($"x = {x}");
Console.WriteLine("Playing with reference types-------:");
int[]? ints = { 0,1,2 };
Console.WriteLine($"ints.length = {ints.Length}");
ints = default;
Console.WriteLine("Setting ints to default");
var val = ints == null ? "null" : "not null";
Console.WriteLine($"ints = {val}");
Console.WriteLine("Playing with passing by reference and value-------:");
int myInt = 10;
Console.WriteLine($"Setting MyInt to 10");
void ChangeIntValueByValue(int x)
{
    x = 20;
}
ChangeIntValueByValue(myInt);
Console.WriteLine($"myInt value won't be 20, even though we ran a changeIntvalue function to set the incoming int to 20");
Console.WriteLine($"myInt = {myInt}");
Console.WriteLine("Instead we are going to pass by reference, to pass the memory address rather than the value of the int");
void ChangeIntValueByReference(ref int x)
{
    x = 20;
}
ChangeIntValueByReference(ref myInt);
Console.WriteLine($"myInt has been passed by reference and the value is now 20");
Console.WriteLine($"myInt = {myInt}");
Console.WriteLine("-----------------------");
Console.WriteLine("Now testing with a reference type, and modifying that value instead, seeing that we don't need the ref keyword");
List<int> list = new();
list.Add(0);
list.Add(1);
list.Add(2);
Console.WriteLine($"list[0] = {list[0]} (should be 0)");
Console.WriteLine("Changing first item in list to 10, without using ref keyword");
void ChangeListValue(List<int> list)
{
    list[0] = 10;
}
ChangeListValue(list);
Console.WriteLine($"list[0] = {list[0]} (should be 10), proving its a reference type, and doesn't need the ref keyword");







/*
int defaultIntOld = default(int);  //0
float defaultFloatOld = default(float);  //0.0
bool defaultBoolOld = default(bool);  //false
char defaultCharOld = default(char);  //'\0'
DateTime defaultDateTimeOld = default(DateTime);  //1/1/0001 12:00:00 AM

// For reference types
string defaultStringOld = default(string);  //null



int defaultInt = default;  //0
float defaultFloat = default;  //0.0
bool defaultBool = default;  //false
char defaultChar = default;  //'\0'
DateTime defaultDateTime = default;  //1/1/0001 12:00:00 AM

// For reference types
string defaultString = default;  //null

*/