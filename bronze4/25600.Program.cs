// https://www.acmicpc.net/problem/25600

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
int maxSum = 0;
while(n-- != 0){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    int a = data[0];    int d = data[1];    int g = data[2];
    int sum = a * (d+g);
    if(a == (d+g)) sum *= 2;
    maxSum = Math.Max(maxSum, sum);
}
Console.WriteLine(maxSum);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();