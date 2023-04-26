// https://www.acmicpc.net/problem/23825

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
Console.WriteLine(Math.Min(data[0]/2 , data[1]/2));

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();