//https://www.acmicpc.net/problem/13623

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var n = sr.ReadLine().Split(" ");
var nInt = new int[n.Length];
var sum = 0;
string[] result = {"*", "A", "B", "C"};
for(int i=0; i<n.Length; i++){
    nInt[i] = int.Parse(n[i]);
    sum += nInt[i];
}
for(int i=0; i<n.Length; i++){
    if(sum == 1 && nInt[i] == 1) {
        Console.Write(result[i+1]);
        return;
    } else if(sum == 2 && nInt[i] == 0) {
        Console.Write(result[i+1]);
        return;
    }
}
Console.WriteLine(result[0]);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();