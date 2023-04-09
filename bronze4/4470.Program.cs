//https://www.acmicpc.net/problem/4470

using System.Text;

int n, count = 1;
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;

StringBuilder sb = new StringBuilder();
n = int.Parse(sr.ReadLine());
for(int i=0; i<n; i++){
    sb.AppendLine(count++ + ". " + sr.ReadLine());
}
sw.Write(sb.ToString());