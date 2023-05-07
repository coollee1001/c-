// https://www.acmicpc.net/problem/26767

using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;
StringBuilder sb = new StringBuilder();

int n = int.Parse(sr.ReadLine());
for(int i=1; i<=n; i++){
    if(i%7 == 0 && i%11 == 0){
        sb.AppendLine("Wiwat!");
    }else if(i%7 == 0){
        sb.AppendLine("Hurra!");
    }else if(i%11 == 0){
        sb.AppendLine("Super!");
    }else{
        sb.AppendLine(i+"");
    }
}
sw.Write(sb.ToString());
sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
