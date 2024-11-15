namespace Task_1.Classes;

public class Pos : IObject
{
    public int X { get; set; }
    public int Y { get; set; }
    public Pos(int x, int y)
    {
        X = x;
        Y = y;
    }


    public object Clone()
    {
        return new Pos(X, Y);
    }
}
