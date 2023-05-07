// https://www.acmicpc.net/problem/27213

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

ulong m = ulong.Parse(sr.ReadLine());
ulong n = ulong.Parse(sr.ReadLine());

ulong result = 0;
if(n == 1 || m == 1) result = (m+n)-1;
else result = (n*2)+(m*2)-4;
sw.WriteLine(result);
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
