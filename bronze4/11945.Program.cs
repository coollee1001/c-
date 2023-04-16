//https://www.acmicpc.net/problem/11945

using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;
StringBuilder sb = new StringBuilder();

var nm = sr.ReadLine().Split(" ");
for(int i=0; i<int.Parse(nm[0]); i++){
    var temp = sr.ReadLine();
    for(int j=int.Parse(nm[1])-1; j>=0; j--){
        sb.Append(temp.Substring(j, 1));
    }
    sb.Append("\n");
}
sw.WriteLine(sb.ToString());

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();