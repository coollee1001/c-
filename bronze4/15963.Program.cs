// https://www.acmicpc.net/problem/15963

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var n = sr.ReadLine().Split(" ");
var nArr = Array.ConvertAll(n, int.Parse);
if(nArr[0] == nArr[1]) Console.WriteLine(1);
else Console.WriteLine(0);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

