// https://www.acmicpc.net/problem/21354

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
Console.WriteLine(data[0]*7 < data[1]*13?"Petra":data[0]*7 == data[1]*13?"lika":"Axel");

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


