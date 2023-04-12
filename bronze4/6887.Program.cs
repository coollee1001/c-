//https://www.acmicpc.net/problem/6887

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int squares = int.Parse(sr.ReadLine());
Console.WriteLine("The largest square has side length {0}.", Math.Truncate(Math.Sqrt(squares)));


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

