//https://www.acmicpc.net/problem/4589

using System.Text;

int n, sbLength;
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;

StringBuilder sb = new StringBuilder();
n = int.Parse(sr.ReadLine());
for(int i=1; i<=n; i++){
    string[] temp = sr.ReadLine().Split(" ");
    string[] sortTemp = (string[])temp.Clone();
    string[] reverseTemp = (string[])temp.Clone();
    Array.Sort(sortTemp);
    Array.Sort(reverseTemp); Array.Reverse(reverseTemp);
    for(int j=0; j<temp.Length; j++){
        if(!temp[j].Equals(sortTemp[j])) {
            if(!temp[j].Equals(reverseTemp[j])){
                sb.AppendLine("Unordered");
                break;
            }
        }
    }
    sbLength = sb.ToString().Split("\n").Length -1;
    if(sbLength != i) sb.AppendLine("Ordered");
}
Console.WriteLine("Gnomes:");
sw.Write(sb.ToString());

// github용 파일 복사
Filecopy fc = new Filecopy(4471);
File.Copy(fc.getThisPath(), fc.getTargetPath());