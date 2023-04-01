
class Activity
{
    private string name;
    protected double distance;
    protected double time;

    public Activity(string name, double distance, double time)
    {
        this.name = name;
        this.distance = distance;
        this.time = time;
    }

    public virtual double GetDistance()
    {
        return distance;
    }

    public virtual double GetSpeed()
    {
        return distance / time;
    }

    public virtual double GetPace()
    {
        return time / distance;
    }

    public virtual string GetSummary()
    {
        string unit = "miles";
        double speed = GetSpeed();
        double pace = GetPace();

        if (this is CyclingActivity)
        {
            unit = "kilometers";
            speed *= 3.6; // convert meters per second to kilometers per hour
            pace = 60 / pace; // convert seconds per kilometer to minutes per kilometer
        }
        else if (this is SwimActivity)
        {
            unit = "yards";
            pace *= 1.09361; // convert minutes per meter to minutes per yard
        }

        return $"{DateTime.Now.ToString("dd MMM yyyy")} {name} ({time} min) - Distance {distance:F1} {unit}, Speed {speed:F1} mph, Pace {pace:F1} min per {unit}";
    }
}