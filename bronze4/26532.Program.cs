// https://www.acmicpc.net/problem/26532

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), double.Parse);
double yard = 4840.0;
double corn = 5.0;

int bag = (int)Math.Ceiling(((double)(data[0]*data[1])/yard)/corn);
Console.WriteLine(bag);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
