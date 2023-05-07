// https://www.acmicpc.net/problem/27541

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
string str = sr.ReadLine();

if(str[n-1] == 'G') sw.WriteLine(str.Substring(0, n-1));
else sw.WriteLine(str + "G");
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
