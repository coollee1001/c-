// https://www.acmicpc.net/problem/21591

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
Console.WriteLine(1<data[0]-data[2] && 1<data[1]-data[3]?1:0);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


