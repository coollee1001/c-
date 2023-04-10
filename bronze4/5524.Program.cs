//https://www.acmicpc.net/problem/5524

using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();    
sw.AutoFlush = true;

int n = int.Parse(sr.ReadLine());
for(int i=0; i<n; i++){
    sb.AppendLine(sr.ReadLine().ToLower());
}

sw.WriteLine(sb.ToString());

// github용 파일 복사
 Filecopy fc = new Filecopy(5524);
 File.Copy(fc.getThisPath(), fc.getTargetPath());