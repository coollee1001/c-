// https://www.acmicpc.net/problem/25628

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
int a = data[0];    int b = data[1];
Console.WriteLine(Math.Min(a/2, b));


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();