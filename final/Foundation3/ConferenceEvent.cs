using System;
class ConferenceEvent : Event
{
    private string speakerName;

    public ConferenceEvent(string name, DateTime date, Address address, string speakerName)
        : base(name, date, address)
    {
        this.speakerName = speakerName;
    }

    public override string GetMarketingMessage()
    {
        return $"Learn from {speakerName} at {GetName()} on {GetDate().ToShortDateString()} at {GetAddress().GetAddressString()}!";
    }
}