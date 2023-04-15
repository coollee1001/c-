//https://www.acmicpc.net/problem/11121

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var n = int.Parse(sr.ReadLine());
for(int i=0; i<n; i++){
    var bit = sr.ReadLine().Split(" ");
    if(bit[0].Equals(bit[1]))   Console.WriteLine("OK");
    else Console.WriteLine("ERROR");
}


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

