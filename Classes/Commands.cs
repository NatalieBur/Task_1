namespace Task_1.Classes;

public class Commands
{
    public static void Help()
    {
        Console.WriteLine("/help - Вывод всех команд\n" +
            "/exit - Завершть программу\n" +
            "/createplayer Name - Создать нового игрока\n" +
            "/player UserID - Вывод информации об игроке\n" +
            "/playerinv UserID - Вывод информации об инвентаре игрока\n" +
            "/itemlist - Вывод всех существующих предметов\n" +
            "/additem UserID ItemID - Добавить предмет в инвентарь\n" +
            "/removeitem UserID ItemID - Удалить предмет из инвентаря\n" +
            "/top - Топ игроков");
    }
}

