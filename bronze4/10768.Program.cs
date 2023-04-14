//https://www.acmicpc.net/problem/10768

StreamReader sr = new StreamReader(Console.OpenStandardInput());

DateTime dt = new DateTime(2015, 2, 18);
DateTime inputDt = new DateTime(2015, int.Parse(sr.ReadLine()), int.Parse(sr.ReadLine()));
if(inputDt.CompareTo(dt) == 0) Console.WriteLine("Special");
else if(inputDt.CompareTo(dt) == -1) Console.WriteLine("Before");
else Console.WriteLine("After");

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

