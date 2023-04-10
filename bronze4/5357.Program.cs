//https://www.acmicpc.net/problem/5357

using System.Text;

int n;
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;

StringBuilder sb = new StringBuilder();
n = int.Parse(sr.ReadLine());
for(int i=1; i<=n; i++){
    string inputApb = sr.ReadLine();
    List<char> list = inputApb.ToList();
    sb.Append(list[0]);
    for(int j=0; j<list.Count()-1; j++){
        if(!list[j].Equals(list[j+1])) sb.Append(list[j+1]);
    }
    sb.Append("\n");
}
sw.WriteLine(sb.ToString());

// github용 파일 복사
Filecopy fc = new Filecopy(5357);
File.Copy(fc.getThisPath(), fc.getTargetPath());