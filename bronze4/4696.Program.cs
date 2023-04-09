//https://www.acmicpc.net/problem/4696

using System.Text;

float n;
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;

StringBuilder sb = new StringBuilder();
while((n = float.Parse(sr.ReadLine())) != 0){
    float sum = (1) // 나
        + (n) // 아내
        + (n * n) // 자루
        + (n * n * n) //고양이
        + (n * n * n * n) //새끼 고양이
        ;
    sb.AppendLine(String.Format("{0:0.00}", Math.Round(sum * 100)/100.0));
}
sw.WriteLine(sb.ToString());

// github용 파일 복사
Filecopy fc = new Filecopy(4696);
File.Copy(fc.getThisPath(), fc.getTargetPath());