using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("You are going to create two Marketing messages for a concert and a conference.");
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("First, we will collect an address which will be the same for both of the events.");
        Thread.Sleep(1500);
        Console.WriteLine();
        Console.WriteLine("What is the street address?");
        string streetAdd = Console.ReadLine();
        var address = new Address(streetAdd);

        Console.Clear();
        Console.WriteLine("Next we will be choosing the event name, date and the band/speaker.");
        Thread.Sleep(2000);
        Console.WriteLine("What is the first events name?");
        string eventName1 = Console.ReadLine();

            Console.WriteLine("What is the second events name?");
        string eventName2 = Console.ReadLine();

        Console.WriteLine("What is the year of the first event?");
        var yearEvent1 = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the month of the first event?");
        var monthEvent1 = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the day of the first event?");
        var dayEvent1 = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the year of the second event?");
        var yearEvent2 = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the month of the second event?");
        var monthEvent2 = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the day of the second event?");
        var dayEvent2 = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the speakers for the first events name?");
        string speakerEvent = Console.ReadLine();

        Console.WriteLine("What is the bands name?");
        string bandEvent = Console.ReadLine();

        var concertEvent = new ConcertEvent(eventName1, new DateTime(yearEvent1, monthEvent1, dayEvent1), address, bandEvent);
        var conferenceEvent = new ConferenceEvent(eventName2, new DateTime(yearEvent2, monthEvent2, dayEvent2), address, speakerEvent);

        Console.WriteLine(concertEvent.GetMarketingMessage());
        Console.WriteLine(conferenceEvent.GetMarketingMessage());
    }
}