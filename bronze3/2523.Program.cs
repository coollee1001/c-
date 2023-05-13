// https://www.acmicpc.net/problem/2523

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
for(int i=1; i<=2*n-1; i++){
    for(int j=1; j<=(i<n?i:2*n-i); j++) sw.Write("*");
    sw.WriteLine();
}

sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
