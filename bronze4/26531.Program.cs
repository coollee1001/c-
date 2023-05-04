// https://www.acmicpc.net/problem/26531

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = sr.ReadLine().Split(" ");
string result = "NO";
if(int.Parse(data[0]) + int.Parse(data[2]) == int.Parse(data[4])) result = "YES";
Console.WriteLine(result);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
