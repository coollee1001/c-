//https://www.acmicpc.net/problem/14924

StreamReader sr = new StreamReader(Console.OpenStandardInput());
var arr = sr.ReadLine().Split(" ");
var arrInt = Array.ConvertAll(arr, int.Parse);

var time = arrInt[2]/(arrInt[0] * 2);
Console.WriteLine(time * arrInt[1]);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
