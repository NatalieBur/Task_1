namespace Task_1.Classes;

public class Player
{
    public string Name { get; set; }
    public string Inventory { get; set; }
    public int Pos { get; set; }
    public int UserID { get; set; }
    public Player()
    {
        _RndUserId();
    }

    public Player(string name, int userId, string inventory, int pos)
    {
        Name = name;
        UserID = userId;
        Inventory = inventory;
        Pos = pos;
    }
    private void _RndUserId()
    {
        Random rnd = new();
        UserID = rnd.Next(899999) + 100000;
    }

    public override string ToString()
    {
        return $"Name: {Name}, UserID: {UserID}, Position: {Pos}, Items: {Inventory}";
    }
}
