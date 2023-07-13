var myList = new MyList<float>();
myList.Print();
var mySecondList = new MyList<int>();
mySecondList.Print();

public class MyList<Things>
{
    Things _item;
    public void Print()
    {
        Console.WriteLine(_item.GetType());
    }
}