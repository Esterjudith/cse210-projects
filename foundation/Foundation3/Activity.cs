using System.Runtime.CompilerServices;

public abstract class  Activity
{
   private DateTime _date;
   private int _time;



    public Activity(DateTime date, int time)
    {
        _date = date;
        _time = time;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetTime()
    {
        return _time;
    }
    
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {       
        return $"{GetDate().ToString("dd MMM yyy")} {this.GetType()} ({GetTime()} min) - Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }

      
     
    
}