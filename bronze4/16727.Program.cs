// https://www.acmicpc.net/problem/16727

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var a = sr.ReadLine().Split(" ");
var b = sr.ReadLine().Split(" ");

var aArr = Array.ConvertAll(a, double.Parse);
var bArr = Array.ConvertAll(b, double.Parse);

var aSum = aArr[0] + bArr[1];
var bSum = aArr[1] + bArr[0];

if(aSum == bSum){
    if(aArr[0] == bArr[0]) Console.WriteLine("Penalty");
    else Console.WriteLine(aArr[0]<bArr[0]?"Persepolis":"Esteghlal");
}else{
    Console.WriteLine(aSum<bSum?"Esteghlal":"Persepolis");
}





// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


