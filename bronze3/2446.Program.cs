// https://www.acmicpc.net/problem/2446

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
for(int i=1; i<=n; i++){
    for(int j=1; j<i; j++){
        sw.Write(" ");
    }
    for(int j=2*n - (2*i-1); j>=1; j--){
        sw.Write("*");
    }
    sw.WriteLine();
}
for(int i=2; i<=n; i++){
    for(int j=n-i; j>=1; j--){
        sw.Write(" ");
    }
    for(int j=1; j<=(2*i-1); j++){
        sw.Write("*");
    }
    sw.WriteLine();
}
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
