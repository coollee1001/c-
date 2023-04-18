//https://www.acmicpc.net/problem/14038

StreamReader sr = new StreamReader(Console.OpenStandardInput());
int sum = 0, result = -1;
for(int i=0; i<6; i++){
    if(sr.ReadLine() == "W"){
        sum += 1;
    }
}
if(1 <= sum && sum < 3) result = 3;
else if(3 <= sum && sum < 5  ) result = 2;
else if(5 <= sum && sum <= 6) result = 1;
Console.WriteLine(result);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();