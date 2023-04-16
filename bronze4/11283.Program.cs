//https://www.acmicpc.net/problem/11283

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var n = Convert.ToChar(sr.ReadLine());
// 유니코드 시작 AC00 : 44032
Console.WriteLine("{0}", Convert.ToInt32(n) - 44031);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();