using T1;

System.Console.Write("Enter your FirstName: ");
string a = Console.ReadLine();
System.Console.Write("Enter your LastName: ");
string b = Console.ReadLine();
System.Console.Write("Enter your you Age: ");
int c = Convert.ToInt32(Console.ReadLine());

Person person = new Person(a, b, c);
person.GetInfo();