//https://www.acmicpc.net/problem/6888

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int x = int.Parse(sr.ReadLine());
int y = int.Parse(sr.ReadLine());

for(int i=x; i<=y; i=i+60){
    Console.WriteLine("All positions change in year {0}", i);
}


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

