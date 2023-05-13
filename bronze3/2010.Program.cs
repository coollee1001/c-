// https://www.acmicpc.net/problem/2010

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var n = int.Parse(sr.ReadLine());
int sum = 1;
for(int i=0; i<n; i++){
    sum += int.Parse(sr.ReadLine())-1;
}
sw.WriteLine(sum);
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
