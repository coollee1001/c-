//https://www.acmicpc.net/problem/5575

using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();    
sw.AutoFlush = true;


int n = 3;
for(int i=0; i<n; i++){
    string[] temp = sr.ReadLine().Split(" ");
    DateTime startTime = new DateTime(1970, 1, 1, int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2]));
    DateTime endTime = new DateTime(1970, 1, 1, int.Parse(temp[3]), int.Parse(temp[4]), int.Parse(temp[5]));
    endTime = endTime.AddSeconds(-startTime.Second);
    endTime = endTime.AddMinutes(-startTime.Minute);
    endTime = endTime.AddHours(-startTime.Hour);
    sb.AppendLine(String.Format("{0} {1} {2}", endTime.Hour, endTime.Minute, endTime.Second));
}
sw.WriteLine(sb.ToString());


// github용 파일 복사
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Code Num > ");
Console.ForegroundColor = ConsoleColor.White;
Filecopy fc = new Filecopy(int.Parse(sr.ReadLine()));
try{
    File.Copy(fc.getThisPath(), fc.getTargetPath(), true);
}catch(Exception e){
    Console.WriteLine(e.ToString());
}finally{
    Console.WriteLine("save done");
}