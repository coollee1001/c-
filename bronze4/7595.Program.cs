//https://www.acmicpc.net/problem/7595

using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();
sw.AutoFlush = true;

string input = "";
while((input = sr.ReadLine()) != "0"){
    for(int i=0; i<int.Parse(input); i++){
        for(int j=0; j<=i; j++){
            sb.Append("*");
        }
        sb.Append("\n");
    }
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

