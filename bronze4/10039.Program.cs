//https://www.acmicpc.net/problem/10039

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int sum = 0, temp = 0;
for(int i = 0; i<5; i++){
    temp = int.Parse(sr.ReadLine());
    sum += temp < 40 ?40:temp;
}
Console.WriteLine(sum/5);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

