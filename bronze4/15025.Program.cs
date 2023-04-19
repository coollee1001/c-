//https://www.acmicpc.net/problem/15025

StreamReader sr = new StreamReader(Console.OpenStandardInput());
var inputArr = sr.ReadLine().Split(" ");
var inputInt = Array.ConvertAll(inputArr, int.Parse);

if(inputInt[0] == 0 && inputInt[1] == 0) Console.WriteLine("Not a moose");
else if(inputInt[0] == inputInt[1]) Console.WriteLine("Even {0}", inputInt[0] * 2);
else Console.WriteLine("Odd {0}", Math.Max(inputInt[0], inputInt[1]) * 2);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
