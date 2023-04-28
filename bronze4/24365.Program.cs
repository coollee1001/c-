// https://www.acmicpc.net/problem/24365

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
var avg = (data[0] + data[1] + data[2])/3;

var bee = 2*(avg - data[0]) + 1*(avg - data[1]);

Console.WriteLine(bee);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();