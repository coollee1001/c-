// https://www.acmicpc.net/problem/18330

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
int k = int.Parse(sr.ReadLine());

int minValue = Math.Min(k+60, n);
Console.WriteLine(minValue*1500 + (n-minValue)*3000);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


