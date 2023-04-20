// https://www.acmicpc.net/problem/16693

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var a = sr.ReadLine().Split(" ");
var b = sr.ReadLine().Split(" ");

var aArr = Array.ConvertAll(a, double.Parse);
var bArr = Array.ConvertAll(b, double.Parse);

var aR = bArr[0] * bArr[0] * Math.PI / bArr[1];
var bR = aArr[0] / aArr[1];

Console.WriteLine(bR < aR?"Whole pizza":"Slice of pizza");



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


