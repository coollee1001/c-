// https://www.acmicpc.net/problem/25991

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
var data = Array.ConvertAll(sr.ReadLine().Split(" "), double.Parse);
double sum = 0;
for(int i=0; i<n; i++){
    sum += Math.Pow(data[i], 3);
}
Console.WriteLine(Math.Cbrt(sum));

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();