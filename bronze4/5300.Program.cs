//https://www.acmicpc.net/problem/5300

using System.Text;

int n;
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;

StringBuilder sb = new StringBuilder();
n = int.Parse(sr.ReadLine());
for(int i=1; i<=n; i++){
    sb.Append(i + " ");
    if(i%6 == 0 || i==n){
        sb.Append("Go!");
        if(i!=n) sb.Append(" ");
    }
}
sw.WriteLine(sb.ToString());

// github용 파일 복사
Filecopy fc = new Filecopy(5300);
File.Copy(fc.getThisPath(), fc.getTargetPath());