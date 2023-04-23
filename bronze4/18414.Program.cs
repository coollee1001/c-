// https://www.acmicpc.net/problem/18414

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var abc = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
Array.Sort(abc);
Console.WriteLine(abc[1]);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


