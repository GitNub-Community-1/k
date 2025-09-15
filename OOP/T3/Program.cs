BusRoute route = new BusRoute();
route.SetRouterName("37", 4);
route.AddStop("Центр");
route.AddStop("Базар");
route.AddStop("Университет");

System.Console.WriteLine(route.GetTotalTime());
// → Общее время маршрута: 8 минут

route.GetNextStop("Базар");
// → Следующая остановка: Университет