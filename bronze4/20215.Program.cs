// https://www.acmicpc.net/problem/20215

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var wh = Array.ConvertAll(sr.ReadLine().Split(" "), double.Parse);
double rectangle = wh[0] + wh[1];
double diagonal = Math.Sqrt((wh[0]*wh[0]) + (wh[1]*wh[1]));
Console.WriteLine(rectangle-diagonal);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


