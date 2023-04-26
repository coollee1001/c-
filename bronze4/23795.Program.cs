// https://www.acmicpc.net/problem/23795

StreamReader sr = new StreamReader(Console.OpenStandardInput());

long n = 0;
ulong sum = 0;
while((n = long.Parse(sr.ReadLine())) != -1){
    sum += (ulong)n;
}
Console.WriteLine(sum);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();