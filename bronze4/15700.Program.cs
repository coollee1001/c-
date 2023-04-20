//https://www.acmicpc.net/problem/15700

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;

var inputData = sr.ReadLine().Split(" ");
var longInputData = Array.ConvertAll(inputData, long.Parse);
var nm = longInputData[0] * longInputData[1];
sw.Write(nm / 2);
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

