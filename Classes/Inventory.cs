namespace Task_1.Classes;

public class Inventory : IObject
{
    List<string> strings = new();

    public object Clone()
    {
        return new List<Item>();
    }
}