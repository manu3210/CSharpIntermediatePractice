public class Stopwatch
{
    public DateTime Beginning { get; set;}
    public DateTime End { get; set;}
    public List<TimeSpan> Intervals { get; set;}

    public Stopwatch()
    {
        Intervals = new List<TimeSpan>();
    }

    public void Start()
    {
        Beginning = DateTime.Now;
    }

    public void Stop()
    {
        End = DateTime.Now;
        Intervals.Add(End - Beginning);
    }

    public TimeSpan GetTotalTime()
    {
        TimeSpan total = new TimeSpan();

        foreach(var interval in Intervals)
        {
            total += interval;
        }

        return total;
    }
}

