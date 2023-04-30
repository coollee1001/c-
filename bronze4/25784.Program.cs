// https://www.acmicpc.net/problem/25784

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
Array.Sort(data);
int result = 3;
if(data[0]+data[1]==data[2]) result = 1;
else if(data[0]*data[1]==data[2]) result = 2;
Console.WriteLine(result);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();