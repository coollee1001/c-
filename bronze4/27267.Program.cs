// https://www.acmicpc.net/problem/27267

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
sw.WriteLine(data[0]*data[1]<data[2]*data[3]?"P":data[0]*data[1]==data[2]*data[3]?"E":"M");
sw.Close();



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
