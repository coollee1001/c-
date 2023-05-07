// https://www.acmicpc.net/problem/27262

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
sw.WriteLine("{0} {1}", Math.Abs(1-data[1])*data[3]+(data[0]-1)*data[3], (data[0]-1)*data[2]);
sw.Close();



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
