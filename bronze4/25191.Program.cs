// https://www.acmicpc.net/problem/25191

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int chicken = int.Parse(sr.ReadLine());
var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);

Console.WriteLine(Math.Min(chicken, (data[0]/2)+data[1]));


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();