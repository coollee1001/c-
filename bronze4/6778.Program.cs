//https://www.acmicpc.net/problem/6778

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int antenna = int.Parse(sr.ReadLine());
int eyes = int.Parse(sr.ReadLine());

if(3 <= antenna && eyes <= 4) Console.WriteLine("TroyMartian");
if(antenna <= 6 && 2 <= eyes) Console.WriteLine("VladSaturnian");
if(antenna <= 2 && eyes <= 3) Console.WriteLine("GraemeMercurian");

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

