public class Room
{
    public int Number;
    public string Type;
    public double Price;
    public bool IsBooked;

    public Room(int number, string type, double price)
    {
        Number = number;
        Type = type;
        Price = price;
        IsBooked = false;
    }

    public string GetInfo()
    {
        string status = "Свободна";
        if (IsBooked)
        {
            status = "Забронирована";
        }

        return "Комната #" + Number + " (" + Type + ") - " + Price + " сомони - " + status;
    }
}
