BankAccount acc1 = new BankAccount("Али", "111", 15000, "Сберегательный");
BankAccount acc2 = new BankAccount("Мунира", "222", 5000, "Текущий");
acc1.Deposit(2000);
acc1.TransferTo(acc2, 7000);