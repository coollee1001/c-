//https://www.acmicpc.net/problem/15080

StreamReader sr = new StreamReader(Console.OpenStandardInput());
var aInput = sr.ReadLine().Split(" : ");
var bInput = sr.ReadLine().Split(" : ");

var aArr = Array.ConvertAll(aInput, int.Parse);
var bArr = Array.ConvertAll(bInput, int.Parse);

int startTime = aArr[2] + (aArr[1] * 60) + (aArr[0] * 60 * 60);
int endTime = bArr[2] + (bArr[1] * 60) + (bArr[0] * 60 * 60);

if(endTime < startTime) // 하루가 넘음
Console.WriteLine( (24 * 60 * 60) - startTime + endTime);
else
Console.WriteLine(endTime - startTime);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
