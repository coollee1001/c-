// https://www.acmicpc.net/problem/16204

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var card = sr.ReadLine().Split(" ");
var cardArr = Array.ConvertAll(card, int.Parse);

Console.WriteLine(Math.Min(cardArr[1], cardArr[2]) + Math.Min(cardArr[0] - cardArr[1], cardArr[0] - cardArr[2]));


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

