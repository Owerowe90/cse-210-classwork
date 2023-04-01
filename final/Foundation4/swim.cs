class SwimActivity : Activity
{
     private int laps;
    private int poolLength;

    public SwimActivity(string name, int laps, int poolLength, double time)
        : base(name, laps * poolLength, time)
    {
        this.laps = laps;
        this.poolLength = poolLength;
    }

    public override double GetDistance()
    {
        return base.GetDistance(); // no need to override this method for swimming activities
    }

    public override double GetSpeed()
    {
        double yardsPerMinute = distance / time;
        double yardsPerSecond = yardsPerMinute / 60;
        double metersPerSecond = yardsPerSecond * 0.9144; // convert yards per second to meters per second
        return metersPerSecond * 2.23694; // convert meters per second to miles per hour
    }
    
    public override double GetPace()
    {
        double secondsPerMeter = time / (distance / 1000); // convert meters per second to seconds per meter
        return secondsPerMeter / 60; // convert seconds per meter to minutes per meter
    }

    public override string GetSummary()
    {
        return $"Swimming {base.GetSummary()}, Laps: {laps}, Pool Length: {poolLength} yards";
    }
}