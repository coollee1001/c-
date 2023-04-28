// https://www.acmicpc.net/problem/24751

StreamReader sr = new StreamReader(Console.OpenStandardInput());

double input = double.Parse(sr.ReadLine());

Console.WriteLine("{0:0.00000000000}",100/input);
Console.WriteLine("{0:0.00000000000}",100/(100-input));



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();