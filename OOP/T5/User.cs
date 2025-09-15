public class User
{
    public string Name;
    public List<Movie> WatchedMovies = new List<Movie>();

    public User(string name)
    {
        Name = name;
    }

    public void WatchMovie(Movie movie)
    {
        WatchedMovies.Add(movie);
    }

    public void RateMovie(Movie movie, double rating)
    {
        int i = 0;
        while (i < WatchedMovies.Count)
        {
            if (WatchedMovies[i] == movie)
            {
                WatchedMovies[i].Rating = rating;
                return;
            }
            i++;
        }
    }

    public List<Movie> GetWatchHistory()
    {
        return WatchedMovies;
    }

    public List<Movie> RecommendByGenre(string genre)
    {
        List<Movie> recommended = new List<Movie>();
        int i = 0;
        while (i < WatchedMovies.Count)
        {
            if (WatchedMovies[i].Genre == genre)
            {
                recommended.Add(WatchedMovies[i]);
            }
            i++;
        }
        return recommended;
    }

    public double GetAverageRating()
    {
        double total = 0;
        int count = 0;
        int i = 0;
        while (i < WatchedMovies.Count)
        {
            if (WatchedMovies[i].Rating > 0)
            {
                total = total + WatchedMovies[i].Rating;
                count = count + 1;
            }
            i++;
        }

        if (count == 0)
        {
            return 0;
        }

        return total / count;
    }

    public void ShowWatchedMovies()
    {
        Console.WriteLine("Просмотренные фильмы:");
        int i = 0;
        while (i < WatchedMovies.Count)
        {
            Console.WriteLine(WatchedMovies[i].GetInfo());
            i++;
        }
    }
}
