Product p1 = new Product("Ноутбук", 50000, 5);
Product p2 = new Product("Книга", 800, 20);
Order order = new Order();

order.AddProduct(p1, 1);
order.AddProduct(p2, 2);

order.PrintReceipt();
// → Чек:
// 1 x Ноутбук = 50000
// 2 x Книга = 1600
// Общая сумма: 51600