//https://www.acmicpc.net/problem/11549

StreamReader sr = new StreamReader(Console.OpenStandardInput());

string answer = sr.ReadLine();
var submit = sr.ReadLine().Split(" ");
var count = 0;
for(int i=0; i<submit.Length; i++){
    if(submit[i].Equals(answer)) count++;
}
Console.Write(count);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();