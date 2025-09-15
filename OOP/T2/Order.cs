class Order
{
public Dictionary<Product, int> item = new Dictionary<Product, int>();
    public void AddProduct(Product product, int quantity)
    {
        item.Add(product, quantity);
    }
public void RemoveProduct(Product product) 
{
    item.Remove(product);
}
    public decimal TotalPrice()
    {
        decimal total = 0;
        foreach (var tem in item)
        {
            Product product = tem.Key;
            int count = tem.Value;
            total += product.Price * count;
        }
        return total;
    }
    public void PrintReceipt()
    {
    Console.WriteLine("Чек заказа:");
        foreach (var pair in item)
        {
            Console.WriteLine($"{pair.Key.Name} x{pair.Value} = {pair.Key.Price * pair.Value} сом");
        }
        Console.WriteLine($"Итого: {TotalPrice()} сом");
}
    public void ClearOrder()
    {
        item.Clear();
    }
}