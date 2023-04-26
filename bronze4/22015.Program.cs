// https://www.acmicpc.net/problem/22015

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var nm = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
var maxNm = Math.Max(Math.Max(nm[0], nm[1]), nm[2]);
var sum = nm[0] + nm[1] + nm[2];

Console.WriteLine((maxNm * 3)-sum);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


