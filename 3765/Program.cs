//https://www.acmicpc.net/problem/3765

using System.Text;

string temp;
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();
while((temp = sr.ReadLine()) != null){
    sb.AppendLine(temp);
}
sw.Write(sb.ToString());