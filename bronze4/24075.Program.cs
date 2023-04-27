// https://www.acmicpc.net/problem/24075

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
Console.WriteLine(Math.Max(data[0]-data[1], data[0]+data[1]));
Console.WriteLine(Math.Min(data[0]-data[1], data[0]+data[1]));


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();