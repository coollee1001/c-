// https://www.acmicpc.net/problem/20976

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
Array.Sort(data);
Console.WriteLine(data[1]);



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


