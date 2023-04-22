// https://www.acmicpc.net/problem/17356

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var inputAb = sr.ReadLine().Split(" ");
var ab = Array.ConvertAll(inputAb, double.Parse);

double m = (ab[1]-ab[0])/400.0;
double result = 1/(1+Math.Pow(10, m));
Console.WriteLine(result);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


