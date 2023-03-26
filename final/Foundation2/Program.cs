using System;

class Program
{
    static void Main(string[] args)
    {
        Product prod1 = new Product("Shirt", "1234", 29.99, 4);
        Product prod2 = new Product("Dress", "5678", 69.95, 2);
        Product prod3 = new Product("Boots", "9637", 239.99, 1);

        Order order1 = new Order();
        Address address1 = new Address("42516 N. Murphy", "San Tan Valley", "AZ", "USA");
        Customer cust1 = new Customer("Clara Winston", address1);
        order1.AddItem(prod1);
        order1.AddItem(prod3);
        
        order1.PrintTotalCost(address1);
        order1.PrintPackingLabel();
        order1.PrintShippingLabel(address1, cust1);
        Console.WriteLine();

        Order order2 = new Order();
        Address address2 = new Address("56 Crofts Road", "Bemm River", "Victoria", "Australia");
        Customer cust2 = new Customer("Scott Knight", address2);
        order2.AddItem(prod2);
        order2.AddItem(prod3);
        
        order2.PrintTotalCost(address2);
        order2.PrintPackingLabel();
        order2.PrintShippingLabel(address2, cust2);

    }
}