// https://www.acmicpc.net/problem/27332

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var day = int.Parse(sr.ReadLine());
var week = int.Parse(sr.ReadLine())*7;

if(day+week < 31) sw.WriteLine(1);
else sw.WriteLine(0);
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
