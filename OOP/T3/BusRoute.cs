public class BusRoute
{
    public string RouteNumber;
    public List<string> Stops = new List<string>();
    public int TimeBetweenStops;
    public int StopsCount = 0;
    public void SetRouterName(string rout, int stops)
    {
        RouteNumber = rout;
        TimeBetweenStops = stops;
    }
    public void AddStop(string stop)
    {
        Stops.Add(stop);
    }
    public int GetTotalTime()
    {
        if (Stops.Count < 2)
            return 0;
        return TimeBetweenStops * (Stops.Count - 1);
    }
    public void GetNextStop(string curr)
    {
        for (int i = 0; i < Stops.Count; i++)
        {
            if (Stops[i] == curr)
            {
                System.Console.WriteLine(Stops[i + 1]);
            }
        }
    }
    public void RemoveStop(string stop)
    {
        for (int i = 0; i < Stops.Count; i++)
        {
            if (Stops[i] == stop)
            {
                Stops.Remove(Stops[i]);
            }
        }
    }
    public void PrintRoute()
{
    Console.WriteLine($"Маршрут №{RouteNumber}:");

    for (int i = 0; i < Stops.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {Stops[i]}");
    }

    Console.WriteLine($"Общее время маршрута: {GetTotalTime()} минут");
}
}