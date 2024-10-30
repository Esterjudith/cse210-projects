public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int time, int lap) : base(date, time)
    {
        _laps = lap;
    }
     public override double GetDistance()
    {
        return _laps *50/1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance()/GetTime() * 60;
    }

    public override double GetPace()
    {
        return Math.Round(GetTime()/GetDistance(), 2);
    }
}