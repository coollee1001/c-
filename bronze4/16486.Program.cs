// https://www.acmicpc.net/problem/16486

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var d1 = double.Parse(sr.ReadLine());
var d2 = double.Parse(sr.ReadLine());
double pi = 3.141592;

Console.WriteLine("{0:0.000000}",(d1*2.0) + 2 * pi * d2);



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

