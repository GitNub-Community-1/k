namespace T4;
class Employe
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Position;
    public decimal Salary;
    public void SetName(string name, string last, int age, string position)
    {
        FirstName = name;
        LastName = last;
        Age = age;
        Position = position;
    }
    public void SetSalary(decimal salary)
    {
        Salary = salary;
    }
    public decimal GetSalary()
    {
        return Salary;
    }
    public string GetINfo()
    {
        return $"Name: {FirstName}.\n Surname: {LastName}.\n Age:{Age}.\nPosition: { Position}.\n Salary: { Salary} ";
    }
}