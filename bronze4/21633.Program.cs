// https://www.acmicpc.net/problem/21633

StreamReader sr = new StreamReader(Console.OpenStandardInput());

double money = double.Parse(sr.ReadLine());
double fee = money * 0.01 + 25.0;
Console.WriteLine("{0:0.00}",fee<100?100:2000<fee?2000:fee);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


