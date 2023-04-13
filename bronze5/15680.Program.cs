//https://www.acmicpc.net/problem/15680

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
if(n == 0){
    Console.WriteLine("YONSEI");
}else{
    Console.WriteLine("Leading the Way to the Future");
}

// github용 파일 복사
int num = 0;
string level = "";

Console.ForegroundColor = ConsoleColor.Red; Console.Write("Code Num > "); Console.ForegroundColor = ConsoleColor.White;
while(num <= 0){
    num = int.Parse(sr.ReadLine());
}
Console.ForegroundColor = ConsoleColor.Red; Console.Write("Code Level > "); Console.ForegroundColor = ConsoleColor.White;
while(level.Equals("")){
    level = sr.ReadLine();
}

Filecopy fc = new Filecopy(level, num);
try{
    File.Copy(fc.getThisPath(), fc.getTargetPath(), true);
}catch(Exception e){
    Console.WriteLine(e.ToString());
}finally{
    Console.WriteLine("save done");
}

