// https://www.acmicpc.net/problem/21612

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int b = int.Parse(sr.ReadLine());
int result = 5*b-400;
Console.WriteLine(result);
Console.WriteLine(result<100?1:result==100?0:-1);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


