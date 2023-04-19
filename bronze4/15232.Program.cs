//https://www.acmicpc.net/problem/15232

StreamReader sr = new StreamReader(Console.OpenStandardInput());
var iData = int.Parse(sr.ReadLine());
var jData = int.Parse(sr.ReadLine());

for(int i=0; i<iData; i++){
    for(int j=0; j<jData; j++){
        Console.Write("*");
    }
    Console.Write("\n");
}



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

