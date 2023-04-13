//https://www.acmicpc.net/problem/8760

using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;
StringBuilder sb = new StringBuilder();

int testCount = int.Parse(sr.ReadLine());
for(int i=0; i<testCount; i++){
    string[] testData = sr.ReadLine().Split(" ");
    int people = (int.Parse(testData[0]) * int.Parse(testData[1])) / 2;
    sb.AppendLine(String.Format("{0}", people));
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

