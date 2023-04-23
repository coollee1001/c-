// https://www.acmicpc.net/problem/20499

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split("/"), int.Parse);
Console.WriteLine(data[0]+data[2]<data[1] || data[1] == 0?"hasu":"gosu");

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


