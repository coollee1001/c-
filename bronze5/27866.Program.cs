//https://www.acmicpc.net/problem/27866

StreamReader sr = new StreamReader(Console.OpenStandardInput());

string str = sr.ReadLine();
int n = int.Parse(sr.ReadLine());
Console.WriteLine(str[n-1]);


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

