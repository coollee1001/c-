// https://www.acmicpc.net/problem/25828

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
int result = 2;
if(data[0]*data[1] < (data[1]*data[2])+data[0]) result = 1;
else if(data[0]*data[1] == (data[1]*data[2])+data[0]) result = 0;
Console.WriteLine(result);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();