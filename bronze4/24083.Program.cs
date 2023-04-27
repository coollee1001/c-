// https://www.acmicpc.net/problem/24083

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int a = int.Parse(sr.ReadLine());
int b = int.Parse(sr.ReadLine());

Console.WriteLine((a+b)%12==0?12:(a+b)%12);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();