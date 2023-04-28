// https://www.acmicpc.net/problem/24860

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data1 = Array.ConvertAll(sr.ReadLine().Split(" "), long.Parse);
var data2 = Array.ConvertAll(sr.ReadLine().Split(" "), long.Parse);
var data3 = Array.ConvertAll(sr.ReadLine().Split(" "), long.Parse);

var data1add = data1[0] * data1[1];
var data2add = data2[0] * data2[1];
var data3add = data3[0] * data3[1] * data3[2];

Console.WriteLine((data1add + data2add) * data3add);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();