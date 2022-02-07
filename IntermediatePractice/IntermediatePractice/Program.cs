/* Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
provide two methods: Start and Stop. We call the start method first, and the stop method next.
Then we ask the stopwatch about the duration between start and stop. Duration should be a
value in TimeSpan. Display the duration on the console.
We should also be able to use a stopwatch multiple times. So we may start and stop it and then
start and stop it again. Make sure the duration value each time is calculated properly.
We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
start time). So the class should throw an InvalidOperationException if its started twice. */

var option = "s";
var stopwatch = new Stopwatch();

while (option == "s")
{
    Console.WriteLine("please, press a button to start the stopwatch");
    Console.ReadKey();
    stopwatch.Start();
    Console.WriteLine("To stop the stopwatch, press a button...");
    Console.ReadKey();
    stopwatch.Stop();

    Console.WriteLine("Continue? S/N:");
    option = Console.ReadLine();
}

Console.WriteLine("\n------------------------------------------------------------");
Console.WriteLine("Your time: " + stopwatch.GetTotalTime());
Console.WriteLine("\n");
Console.WriteLine("Your intervals: \n");

foreach (var item in stopwatch.Intervals)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n------------------------------------------------------------");
