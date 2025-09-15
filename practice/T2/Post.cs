public class Post
{
    private string? Text;
    private int Likes;
    private List<string> Comments = new List<string>();
    public void SetPost(string text)
    {
        Text = text;
        System.Console.WriteLine("Текст обупликован как 'Пост' .");
    }
    public void AddLike()
    {
        Likes = Likes + 1;
        System.Console.WriteLine("Вы поставили Лайк.");
    }
    public void AddComments(string comment)
    {
        Comments.Add(comment);
        System.Console.WriteLine($"Ваш коммент: << {comment} >> опубликован. ");
    }
    public void GetInfo()
    {
        System.Console.WriteLine($"Ваш пост: {Text}");
        System.Console.WriteLine($"Количество Лайков: {Likes}");
        System.Console.WriteLine("Комменты: ");
        foreach (var item in Comments)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine($"Общее количество комментов: {Comments.Count}");
        {

        }
    }
}