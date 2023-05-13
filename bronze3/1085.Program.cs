// https://www.acmicpc.net/problem/1085

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
sw.WriteLine("{0}", Math.Min(data[0], Math.Min(data[1], Math.Min(data[2]-data[0], data[3]-data[1]))));
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
