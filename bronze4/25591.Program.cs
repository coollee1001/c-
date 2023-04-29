// https://www.acmicpc.net/problem/25591

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
int a = 100 - data[0];
int b = 100 - data[1];
int c = 100 - (a+b);
int d = a * b;
int e = d/100;
int f = d%100;
Console.WriteLine("{0} {1} {2} {3} {4} {5}", a, b, c, d, e, f);
Console.WriteLine("{0} {1}", c+e, f);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();