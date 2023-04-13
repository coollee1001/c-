//https://www.acmicpc.net/problem/8674

StreamReader sr = new StreamReader(Console.OpenStandardInput());

string[] inputdata = sr.ReadLine().Split(" ");
long a = long.Parse(inputdata[0]);
long b = long.Parse(inputdata[1]);
if(a%2 == 0 && b%2 == 0){
    Console.WriteLine(0);
}else{
    Console.WriteLine("{0}", Math.Min(a, b));
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

