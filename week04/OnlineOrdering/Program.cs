using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(new Customer("Emily Winehouse", new Address("123 Main street", "Springfield", "Illinois", "Usa")));
        Order order2 = new Order(new Customer("Marika Light", new Address("15 Rue de Rivoli", "Paris", " Île-de-France", "France")));

        order1.AddProduct(new Product("Milk", "0065", 1.5, 3));
        order1.AddProduct(new Product("Apple", "6543", 0.65, 5));
        order1.AddProduct(new Product("Pasta", "0035", 1.10, 7));
        order1.AddProduct(new Product("Rice", "4345", 0.90, 1));
        order1.AddProduct(new Product("Juice", "4322", 1.50, 1));
        order2.AddProduct(new Product("Pineapple", "4321", 4.50, 1));
        order2.AddProduct(new Product("Avocado", "2321", 3.50, 5));
        order2.AddProduct(new Product("Sushi", "2111", 25, 2));


        Console.WriteLine($"The total cost is: {order1.CalculateTotalCost()}$");
        Console.WriteLine($"The packing label is: {order1.GetPackingLabel()}");
        Console.WriteLine($"The shipping label is: {order1.GetShippingLabel()}\n");
        Console.WriteLine($"The total cost is: {order2.CalculateTotalCost()}$");
        Console.WriteLine($"The packing label is: {order2.GetPackingLabel()}");
        Console.WriteLine($"The shipping label is: {order2.GetShippingLabel()}\n");

    }
}