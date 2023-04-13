//https://www.acmicpc.net/problem/8710

StreamReader sr = new StreamReader(Console.OpenStandardInput());

string[] inputdata = sr.ReadLine().Split(" ");
long k = long.Parse(inputdata[0]);
long w = long.Parse(inputdata[1]);
long m = long.Parse(inputdata[2]);
int count = 0;
while(k < w){
    k += m;
    count++;
}
Console.WriteLine(count);

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

