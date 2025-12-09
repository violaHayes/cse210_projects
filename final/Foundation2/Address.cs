using System.Data.SqlTypes;

class Address
{
    private string _name;
     private string _street;
     private string _city;
     private string _state;
     private string _zipCode;
     private string _country;
     private bool _inUSA;

     public void GetFullAddress()
    {
        Console.WriteLine($"Address: {_street}");
        Console.WriteLine($"{_city}, {_state}, {_zipCode}");
        Console.WriteLine($"{_country}");

    }


}