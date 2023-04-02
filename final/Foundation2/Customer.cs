using System;
using System.Collections;

public class Customer
{
    private string _firstName;
    private string _lastName;
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country; 

    public List<Customer> cust {get; set; } = new List<Customer>();

    public void SetPerson(string firstname, string lastname)
    {
        _firstName = firstname;
        _lastName = lastname;
    }

    public string GetFullName()
    {
        return _firstName + " " + _lastName;
    } 

    public void SetAddress(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetShipAddress()
    {
        return _streetAddress +  System.Environment.NewLine + _city + ", " + _state + _country;
    }
}