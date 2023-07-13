//Generics
//We can use one function below, instead of writing three!
int[] myInt = { 0, 1, 2 };
string[] myString = { "hello", "there", "mate" };
double[] myDouble = { 0.1, 0.2, 0.3 };

void PrintLoop<Thing>(Thing[] thing)
{
    foreach (Thing t in thing)
    {
        Console.WriteLine(t);
    }
}

PrintLoop(myInt);
PrintLoop(myString);
PrintLoop(myDouble);
