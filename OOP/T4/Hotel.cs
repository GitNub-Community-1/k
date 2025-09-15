public class Hotel
{
    public List<Room> Rooms = new List<Room>();

    public void AddRoom(Room room)
    {
        Rooms.Add(room);
    }

    public void BookRoom(int number)
    {
        for (int i = 0; i < Rooms.Count; i++)
        {
            if (Rooms[i].Number == number && Rooms[i].IsBooked == false)
            {
                Rooms[i].IsBooked = true;
                Console.WriteLine("Комната #" + number + " забронирована.");
            }
            else
            {
            Console.WriteLine("Комната #" + number + " не найдена или уже занята.");    
            }
        }

    }
    public void CancelBooking(int number)
    {
        for (int i = 0; i < Rooms.Count; i++)
        {
            if (Rooms[i].Number == number && Rooms[i].IsBooked == true)
            {
                Rooms[i].IsBooked = false;
                Console.WriteLine("Бронирование комнаты #" + number + " отменено.");
            }
            else
            {
                Console.WriteLine("Комната #" + number + " не была забронирована.");
            }
        }

    }
    public void ShowAvailableRooms()
    {
        Console.WriteLine("Свободные комнаты:");
        for (int i = 0; i < Rooms.Count; i++)
        {
            if (Rooms[i].IsBooked == false)
            {
                Console.WriteLine(Rooms[i].GetInfo());
            }
        }
    }
    public void ShowBookedRooms()
    {
        Console.WriteLine("Забронированные комнаты:");
        for (int i = 0; i < Rooms.Count; i++)
        {
            if (Rooms[i].IsBooked == true)
            {
                Console.WriteLine(Rooms[i].GetInfo());
            }
        }
    }
    public double TotalBookedIncome()
    {
        double total = 0;

        for (int i = 0; i < Rooms.Count; i++)
        {
            if (Rooms[i].IsBooked == true)
            {
                total += Rooms[i].Price;
            }
        }

        return total;
    }
}
