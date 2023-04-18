//https://www.acmicpc.net/problem/14065

StreamReader sr = new StreamReader(Console.OpenStandardInput());
double input = double.Parse(sr.ReadLine());
double galon = 3.785411784d;
double milja = 1.609344d;

Console.WriteLine("{0:0.000000}", 100.0 / (input*(milja/galon)));

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();