// https://www.acmicpc.net/problem/21638

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var todayData = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
var tomorrowData = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);

if(tomorrowData[0] < 0 && 10 <= tomorrowData[1]) Console.WriteLine("A storm warning for tomorrow! Be careful and stay home if possible!");
else if(tomorrowData[0] < todayData[0]) Console.WriteLine("MCHS warns! Low temperature is expected tomorrow.");
else if(todayData[1] < tomorrowData[1]) Console.WriteLine("MCHS warns! Strong wind is expected tomorrow.");
else Console.WriteLine("No message");

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


