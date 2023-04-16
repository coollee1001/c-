//https://www.acmicpc.net/problem/13118

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var peopleX = sr.ReadLine().Split();
var count = 0;
var appleInfo = sr.ReadLine().Split();
var appleInfoInt = new int[3];
for(int i=0; i<appleInfoInt.Length; i++){
    appleInfoInt[i] = int.Parse(appleInfo[i]);
}
for(int i=0; i<peopleX.Length; i++){
    if(appleInfoInt[0] <= int.Parse(peopleX[i]) && int.Parse(peopleX[i]) <= appleInfoInt[0]) count = i+1;
}
Console.WriteLine(count);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();