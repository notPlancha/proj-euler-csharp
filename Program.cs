using euler;
using Timer = euler.Timer;

Timer.startTimer();
long answer = Answers.Problem3();
Timer.stopTimer();

Console.WriteLine($"Answer: {answer}");
Console.WriteLine($"Time: {Timer.Elapsed().TotalMinutes}");