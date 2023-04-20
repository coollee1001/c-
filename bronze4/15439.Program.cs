//https://www.acmicpc.net/problem/15439

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;

int n = int.Parse(sr.ReadLine());
sw.WriteLine(n * (n-1));
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

