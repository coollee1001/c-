//https://www.acmicpc.net/problem/15726

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;

var inputData = sr.ReadLine().Split(" ");
var longInputData = Array.ConvertAll(inputData, double.Parse);
var first = longInputData[0] * longInputData[1] / longInputData[2];
var second = longInputData[0] / longInputData[1] * longInputData[2];
sw.WriteLine(Math.Floor(first < second?second:first));
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

