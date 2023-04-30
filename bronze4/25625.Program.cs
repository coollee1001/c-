// https://www.acmicpc.net/problem/25625

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
int x = data[0];    int y = data[1];
if(y<x) Console.WriteLine(x+y);
else Console.WriteLine(y-x);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();