Movie m1 = new Movie();
m1.SetMovieName("Интерстеллар", "Фантастика", 180, 0);
Movie m2 = new Movie();
m2.SetMovieName("Iron Man", "Фантастика", 120, 0);
User user = new User("Самира");

user.WatchMovie(m1);
user.RateMovie(m1, 9);

user.WatchMovie(m2);
user.RateMovie(m2, 10);

System.Console.WriteLine("Средний рейтинг: "+user.GetAverageRating());
// → Средний рейтинг: 9.5