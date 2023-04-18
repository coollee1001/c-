//https://www.acmicpc.net/problem/13985

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var n = sr.ReadLine().Split(" ");
var nInt = new int[3];
for(int i=0; i<nInt.Length; i++){
    nInt[i] = int.Parse(n[i*2]);
}
Console.WriteLine("{0}", nInt[0] + nInt[1] == nInt[2]?"YES":"NO");

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();