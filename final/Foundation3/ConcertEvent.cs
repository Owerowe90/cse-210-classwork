using System;
class ConcertEvent : Event
{
    private string bandName;

    public ConcertEvent(string name, DateTime date, Address address, string bandName)
        : base(name, date, address)
    {
        this.bandName = bandName;
    }

    public override string GetMarketingMessage()
    {
        return $"Come see {bandName} live at {GetName()} on {GetDate().ToShortDateString()} at {GetAddress().GetAddressString()}!";
    }
}