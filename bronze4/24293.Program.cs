// https://www.acmicpc.net/problem/24293

StreamReader sr = new StreamReader(Console.OpenStandardInput());

long w1 = long.Parse(sr.ReadLine());
long h1 = long.Parse(sr.ReadLine());
long w2 = long.Parse(sr.ReadLine());
long h2 = long.Parse(sr.ReadLine());

Console.WriteLine(4+2*Math.Max(w1, w2)+2*(h1+h2));


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();