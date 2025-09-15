public class Movie
{
    public string Title;
    public string Genre;
    public int Time;
    public double Rating;

    public void SetMovieName(string title, string genre, int time, double rating)
    {
        Title = title;
        Genre = genre;
        Time = time;
        Rating = rating;
    }

    public string GetInfo()
    {
        return "Фильм: " + Title + ". Жанр: " + Genre + ". Длительность: " + Time + " мин. Рейтинг: " + Rating;
    }
}
