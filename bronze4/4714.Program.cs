//https://www.acmicpc.net/problem/4714

using System.Text;

float n;
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;

StringBuilder sb = new StringBuilder();
while((n = float.Parse(sr.ReadLine())) != -1.0){
    float moonWeigh = (float)(n * 0.167);
    sb.AppendLine(String.Format("Objects weighing {0:0.00} on Earth will weigh {1:0.00} on the moon.", n, moonWeigh));
}
sw.WriteLine(sb.ToString());

// github용 파일 복사
Filecopy fc = new Filecopy(4714);
File.Copy(fc.getThisPath(), fc.getTargetPath());