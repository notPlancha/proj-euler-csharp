using euler;
using Timer = euler.Timer;

Timer.startTimer();
(int, int, int) answer = Answers.Problem4();
Timer.stopTimer();

Console.WriteLine($"Answer: {answer}");
Console.WriteLine($"Time: {Timer.Elapsed().TotalMinutes}");