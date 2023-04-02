using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1._orderId = 001;

        Product a = new Product();
        a.SetProduct(1234, "toothpaste", 12, 1);
        order1.products.Add(a);

        Product b = new Product();
        b.SetProduct(5678, "toothbrush", 4, 1);
        order1.products.Add(b);

        Customer c = new Customer();
        c.SetPerson("James", "Doom");
        //order1.cust.Add(c);

        //Address ad1 = new Address();
        c.SetAddress("5940 Williams St", "Gore", "Id", "USA");
        //order1.add.Add(ad1);
        order1.cust.Add(c);

        order1.DisplayShippingLabel();
        order1.products.DisplayPackingLabel();
    }
}