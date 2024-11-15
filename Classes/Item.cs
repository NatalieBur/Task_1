namespace Task_1.Classes;

public class Item : IObject
{
    public string Name { get; set; }
    public string Rarity { get; set; }
    public float Cost { get; set; }
    public int ItemID { get; set; }
    public Item(string name, string rarity, float cost, int itemID)
    {
        Name = name;
        Rarity = rarity;
        Cost = cost;
        ItemID = itemID;
    }
    public object Clone()
    {
        return new Item(Name, Rarity, Cost, ItemID);
    }
}
