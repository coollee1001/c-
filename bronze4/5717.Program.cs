//https://www.acmicpc.net/problem/5717

using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();    
sw.AutoFlush = true;

string inputData;
while((inputData = sr.ReadLine()) != "0 0"){
    string[] inputDataSplit = inputData.Split(" ");
    sb.AppendLine(String.Format("{0}", int.Parse(inputDataSplit[0]) + int.Parse(inputDataSplit[1])));
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