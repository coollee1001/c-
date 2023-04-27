// https://www.acmicpc.net/problem/24072

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), double.Parse);
Console.WriteLine((data[0]+0.5)<=(data[2]+1.0)&&(data[2]+1.0)<=(data[1]+0.5)?1:0);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();