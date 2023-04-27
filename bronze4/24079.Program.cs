// https://www.acmicpc.net/problem/24079

StreamReader sr = new StreamReader(Console.OpenStandardInput());

double x = double.Parse(sr.ReadLine());
double y = double.Parse(sr.ReadLine());
double z = double.Parse(sr.ReadLine()) + 0.5;

Console.WriteLine(x+y<z?1:0);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();