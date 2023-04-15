//https://www.acmicpc.net/problem/10797

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int ten = int.Parse(sr.ReadLine()), count = 0;
var car1Num = sr.ReadLine().Split(" ");
for(int i=0; i<5; i++){
    if(int.Parse(car1Num[i]) == ten){
        count++;
    }
}
Console.WriteLine(count);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

