// https://www.acmicpc.net/problem/24087

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int s = int.Parse(sr.ReadLine());
int a = int.Parse(sr.ReadLine());
int b = int.Parse(sr.ReadLine());

int sum = 250;
while(a<s){
    sum += 100;
    a+=b;
}
Console.WriteLine(sum);



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();