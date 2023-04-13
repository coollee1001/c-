//https://www.acmicpc.net/problem/9772

using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;
StringBuilder sb = new StringBuilder();

string inputData = "";
while((inputData = sr.ReadLine()) != "0 0"){
    string[] tempData = inputData.Split(" ");
    float x = float.Parse(tempData[0]);
    float y = float.Parse(tempData[1]);
    if(x == 0 || y == 0) sb.AppendLine("AXIS");
    else if(x < 0){
        if(y < 0) sb.AppendLine("Q3"); // 음수 + 음수
        else sb.AppendLine("Q2"); // 음수 + 양수
    }else{ 
        if(y < 0) sb.AppendLine("Q4"); // 양수 + 음수
        else sb.AppendLine("Q1"); // 양수 + 양수
    }
}
sb.AppendLine("AXIS");
sw.WriteLine(sb.ToString());


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();