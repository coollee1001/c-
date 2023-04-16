//https://www.acmicpc.net/problem/27959

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var moneyInput = sr.ReadLine().Split();
var money = int.Parse(moneyInput[0]) * 100;
var result = "";
if(int.Parse(moneyInput[1]) <= money) result = "Yes";
else result = "No";
Console.WriteLine(result);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();