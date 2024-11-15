namespace Task_1.Classes;

class Items
{
    string Items1(int item)
    {
        switch (item)
        {
            case 1: return "Щит";
            case 2: return "Меч";
            case 3: return "Кирка";
            default: return null!;
        }
    }
    private void _RndItem()
    {
        Random rnd = new Random(3);
    }
}
