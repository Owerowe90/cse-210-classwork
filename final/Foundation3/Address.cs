using System;
class Address
{
    private string _streetAdd;
    public Address(string streetAdd)
    {
        _streetAdd = streetAdd;
    }

    public string GetAddressString()
    {
        return _streetAdd;
    }
}