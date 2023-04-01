class CyclingActivity : Activity
{
    public CyclingActivity(string name, double distance, double time)
        : base(name, distance, time)
    {
    }

    public override double GetSpeed()
    {
        return base.GetSpeed() * 2.23694; // convert meters per second to miles per hour
    }

    public override string GetSummary()
    {
        return $"Cycling {base.GetSummary()}";
    }
}