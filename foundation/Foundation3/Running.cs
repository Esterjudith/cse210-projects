public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int time, double distance): base(date, time)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance/GetTime() * 60;
    }

    public override double GetPace()
    {
        return GetTime()/_distance;
    }
}