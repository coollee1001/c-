//https://www.acmicpc.net/problem/13136

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var inputData = sr.ReadLine().Split();
var a = new int[3];
for(int i=0; i<a.Length; i++){
    a[i] = int.Parse(inputData[i]);
}
//Math.Ceiling : 소수점 올림
Console.WriteLine(Math.Ceiling((double)a[0]/a[2]) * Math.Ceiling((double)a[1]/a[2]) );



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();