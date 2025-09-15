Player игрок1 = new Player("Абубакр", 10, "Нападающий", "Истиклол");
Player игрок2 = new Player("Фаррух", 7, "Полузащитник", "Истиклол");
Console.WriteLine(игрок1.GetInfo());
Console.WriteLine();
игрок1.ScoreGoal();
игрок2.AssistGoal(игрок1.Name);