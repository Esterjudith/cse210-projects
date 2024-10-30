using System;

class Program
{
    static void Main(string[] args)
    {
      List<Activity> activities= new List<Activity>();

      Running running= new Running(new DateTime(2022, 11, 3), 30, 3.0);
      Cycling cycling= new Cycling(new DateTime(2022, 11, 3), 30, 6.0);
      Swimming swimming= new Swimming(new DateTime(2022, 11, 3), 30, 20);

      activities.Add(running);
      activities.Add(swimming);
      activities.Add(cycling);

      foreach(Activity activity in activities)  
      {
        Console.WriteLine(activity.GetSummary());
      }
    }


}