using euler;
using Timer = euler.Timer;

Timer.startTimer();
var answer = Answers.Problem7();
Timer.stopTimer();

Console.WriteLine($"Answer: {answer}");
Console.WriteLine($"Time: {Timer.Elapsed().TotalMinutes}");