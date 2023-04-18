//https://www.acmicpc.net/problem/13866

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var n = sr.ReadLine().Split(" ");
var nInt = new int[n.Length];
for(int i=0; i<n.Length; i++){
    nInt[i] = int.Parse(n[i]);
}
Console.Write(Math.Abs((nInt[0] + nInt[3]) - (nInt[1] + nInt[2])));

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();