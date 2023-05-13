// https://www.acmicpc.net/problem/2506

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);

int sum = 0;
int count = 0;
for(int i=0; i<n; i++){
    if(data[i] == 1) count++;
    else count = 0;
    sum += (data[i] * count);
}
sw.WriteLine(sum);
sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
