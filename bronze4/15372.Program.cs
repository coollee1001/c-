//https://www.acmicpc.net/problem/15372

using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;
StringBuilder sb = new StringBuilder();

long inputData1 = long.Parse(sr.ReadLine());

for(long i=0; i<inputData1; i++){
    long inputData2 = long.Parse(sr.ReadLine());
    sb.Append(Math.Pow(inputData2, 2) + "\n");
}
sw.Write(sb.ToString());

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

