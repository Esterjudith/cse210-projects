using System.Runtime.InteropServices;

public class Cycling: Activity
{
    private double _speed;

    public Cycling(DateTime date, int time, double speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetTime()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60/_speed;
    }
}