class RunningActivity : Activity
{
    public RunningActivity(string name, double distance, double time)
        : base(name, distance, time)
    {
    }

    public override string GetSummary()
    {
        return $"Running {base.GetSummary()}";
    }
}