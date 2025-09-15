namespace T1;
public class Person
{
    private string FirstName;
    private string LastName;
    private int Age;
    public Person(string first, string last, int age)
    {
        FirstName = first;
        LastName = last;
        Age = age;
    }
    public void GetInfo()
    {
        System.Console.WriteLine("FirstName: " + FirstName);
        System.Console.WriteLine("LastName: " + LastName);
        System.Console.WriteLine("Age: " + Age);
    }
}