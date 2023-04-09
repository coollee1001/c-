//https://www.acmicpc.net/problem/2530

string[] input_currentTime = Console.ReadLine().Split(" ");
int input_cookTime = int.Parse(Console.ReadLine());

DateTime currentTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
currentTime = currentTime.AddHours(int.Parse(input_currentTime[0]));
currentTime = currentTime.AddMinutes(int.Parse(input_currentTime[1]));
currentTime = currentTime.AddSeconds(int.Parse(input_currentTime[2]));
currentTime = currentTime.AddSeconds(input_cookTime);

Console.WriteLine("{0} {1} {2}", currentTime.Hour, currentTime.Minute, currentTime.Second);