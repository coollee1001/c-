// https://www.acmicpc.net/problem/1598

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
data[0]--; data[1]--;
int result = Math.Abs(data[0]/4 - data[1]/4);
result += Math.Abs(data[0]%4 - data[1]%4);
sw.WriteLine(result);
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
