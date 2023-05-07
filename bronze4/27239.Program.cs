// https://www.acmicpc.net/problem/27239

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
int first = (n-1)%8;
int second = (n-1)/8;
sw.Write(char.ConvertFromUtf32('a'+first));
sw.WriteLine(second+1);
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
