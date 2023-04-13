//https://www.acmicpc.net/problem/9316

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int testCount = int.Parse(sr.ReadLine());
for(int i=1; i<=testCount; i++){
    Console.WriteLine(String.Format("Hello World, Judge {0}!", i));
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

