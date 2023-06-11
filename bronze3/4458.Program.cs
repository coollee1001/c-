// https://www.acmicpc.net/problem/4458

using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());

while(n-- != 0){
    var data = sr.ReadLine();
    StringBuilder sb = new StringBuilder(data);
    sb[0] = char.Parse(data.Substring(0,1).ToUpper());
    sw.WriteLine(sb);
}
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
