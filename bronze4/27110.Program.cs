// https://www.acmicpc.net/problem/27110

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
int sum = 0;
for(int i=0; i<data.Length; i++){
    sum += (data[i] < n?data[i]:n);
}
Console.WriteLine(sum);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
