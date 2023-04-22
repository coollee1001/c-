// https://www.acmicpc.net/problem/17874

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var inputData = sr.ReadLine().Split();
var inputDataArr = Array.ConvertAll(inputData, int.Parse);

var result = Math.Max(inputDataArr[1], inputDataArr[0]-inputDataArr[1]) * Math.Max(inputDataArr[2], inputDataArr[0]-inputDataArr[2]);
Console.WriteLine(result*4);



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


