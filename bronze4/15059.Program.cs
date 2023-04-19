//https://www.acmicpc.net/problem/15059

StreamReader sr = new StreamReader(Console.OpenStandardInput());
var a = sr.ReadLine().Split(" ");
var aArr = Array.ConvertAll(a, int.Parse);

var b = sr.ReadLine().Split(" ");
var bArr = Array.ConvertAll(b, int.Parse);

int sum = 0;
for(int i = 0; i<aArr.Length; i++){
    aArr[i] = aArr[i] - bArr[i];
    if(aArr[i] < 0) sum += Math.Abs(aArr[i]);
}

Console.WriteLine(sum);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
