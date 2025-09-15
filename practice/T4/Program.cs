using T4;
Employe empl = new Employe();
empl.SetName("Abubakr", "Mardonov", 15, "Manager");
empl.SetSalary(500);
System.Console.WriteLine(empl.GetSalary());
System.Console.WriteLine(empl.GetINfo());