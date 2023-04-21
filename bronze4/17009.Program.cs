// https://www.acmicpc.net/problem/17009

StreamReader sr = new StreamReader(Console.OpenStandardInput());

const int MAX = 3;
int a = 0, b = 0;
for(int i=0; i<MAX; i++)
    a += int.Parse(sr.ReadLine()) * (MAX - i);
for(int i=0; i<MAX; i++)
    b += int.Parse(sr.ReadLine()) * (MAX - i);
Console.WriteLine(a<b?"B":a==b?"T":"A");





// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


