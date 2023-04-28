// https://www.acmicpc.net/problem/24356

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);

var time1 = data[0] * 60 + data[1];
var time2 = data[2] * 60 + data[3];

int time = 0, tour = 0;

if(time2 < time1) time = 1440 - time1 + time2;
else time = time2 - time1;

tour = time/30;

Console.WriteLine("{0} {1}",time, tour);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();