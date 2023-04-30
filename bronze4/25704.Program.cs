// https://www.acmicpc.net/problem/25704

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
int p = int.Parse(sr.ReadLine());
int money = 0;
switch(n){
    case <5:
        money = p;
        break;
    case <10:
        money = p-500;
        break;
    case <15:
        money = Math.Min(p-(int)(p*0.1), p-500);
        break;
    case <20:
        money = Math.Min(p-2000, Math.Min(p-(int)(p*0.1), p-500));
        break;
    case <=30:
        money = Math.Min(p-(int)(p*0.25), Math.Min(p-2000, Math.Min(p-(int)(p*0.1), p-500)));
        break;
}
Console.WriteLine(0<money?money:0);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();