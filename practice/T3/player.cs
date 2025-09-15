using System;

public class Player
{
    public string Name ;
    public int Number ;
    public string Position ;
    public string Team ;

    public Player(string name, int number, string position, string team)
    {
        Name = name;
        Number = number;
        Position = position;
        Team = team;
    }

    public void ScoreGoal()
    {
        Console.WriteLine($"Гол забил игрок {Name} под номером #{Number}!");
    }

    public void AssistGoal(string playerName)
    {
        Console.WriteLine($"Игрок {Name} сделал ассист на гол игроку {playerName}.");
    }

    public string GetInfo()
    {
        return $"Игрок: {Name}\nНомер: {Number}\nПозиция: {Position}\nКоманда: {Team}";
    }
}
