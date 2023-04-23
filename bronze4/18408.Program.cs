// https://www.acmicpc.net/problem/18408

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var abc = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
Console.WriteLine(abc[0]+abc[1]+abc[2] > 4?2:1);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


