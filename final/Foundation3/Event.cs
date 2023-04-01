using System;
class Event
{
    private string name;
    private DateTime date;
    private Address address;

    public Event(string name, DateTime date, Address address)
    {
        this.name = name;
        this.date = date;
        this.address = address;
    }

    public string GetName()
    {
        return name;
    }

    public DateTime GetDate()
    {
        return date;
    }

    public Address GetAddress()
    {
        return address;
    }

    public virtual string GetMarketingMessage()
    {
        return $"Please join us {name}, on {date.ToShortDateString()} at {address.GetAddressString()}!";
    }
}