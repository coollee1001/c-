//https://www.acmicpc.net/problem/13597

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var n = sr.ReadLine().Split(" ");
var nInt = new int[n.Length];
for(int i=0; i<n.Length; i++){
    nInt[i] = int.Parse(n[i]);
}
Console.WriteLine(Math.Max(nInt[0], nInt[1]));


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();