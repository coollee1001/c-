//https://www.acmicpc.net/problem/13580

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var n = sr.ReadLine().Split(" ");
var nInt = new int[n.Length];
for(int i=0; i<n.Length; i++){
    nInt[i] = int.Parse(n[i]);
}
var nArr = new List<int>(nInt);
nArr.Sort();
if(nArr[0] == nArr[1] || nArr[1] == nArr[2] || nArr[0] + nArr[1] == nArr[2]){
    Console.Write("S");
}else{
    Console.Write("N");
}


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();