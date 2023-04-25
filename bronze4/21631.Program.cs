// https://www.acmicpc.net/problem/21631

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), ulong.Parse);
Console.WriteLine(data[1]<=data[0]?data[1]:data[0]+1);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


