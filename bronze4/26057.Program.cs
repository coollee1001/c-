// https://www.acmicpc.net/problem/26057

StreamReader sr = new StreamReader(Console.OpenStandardInput());

ulong l = ulong.Parse(sr.ReadLine());
ulong t = ulong.Parse(sr.ReadLine());
Console.WriteLine(2*t-l);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();