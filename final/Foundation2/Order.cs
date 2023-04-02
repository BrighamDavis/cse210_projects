using System; 
using System.Collections;

public class Order
{
    public int _orderId;

    /* create a list of products*/ 

    public List<Product> products {get; set; } = new List<Product>();
    public List<Customer> cust {get; set; } = new List<Customer>();
    //public List<Address> add {get; set; } = new List<Address>();

    /* get customer */ 

    /* get parts for shipping label  */  
    public void DisplayShippingLabel()
    {
        foreach (Customer customer in cust)
            {
                Console.WriteLine("Shipping Address :");
                Console.WriteLine(customer.GetFullName());
                Console.WriteLine(customer.GetShipAddress());
            }
    }
/*
    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label :");
        Console.WriteLine(customer.GetFullName());
    }
*/
    public void DisplayTotalPrice()
    {
        Console.WriteLine("");
        /*
        Console.WriteLine(GetTotalPrice());
        */
    }
}