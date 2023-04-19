//https://www.acmicpc.net/problem/15051

StreamReader sr = new StreamReader(Console.OpenStandardInput());
int a1 = int.Parse(sr.ReadLine());
int a2 = int.Parse(sr.ReadLine());
int a3 = int.Parse(sr.ReadLine());

int a1Sum = (a2 * 2) + (a3 * 4);
int a2Sum = (a1 * 2) + (a3 * 2);
int a3Sum = (a2 * 2) + (a1 * 4);

Console.WriteLine(Math.Min(Math.Min(a1Sum, a2Sum), a3Sum));

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
