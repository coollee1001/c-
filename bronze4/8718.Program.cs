//https://www.acmicpc.net/problem/8718

StreamReader sr = new StreamReader(Console.OpenStandardInput());

string[] inputdata = sr.ReadLine().Split(" ");
long x = long.Parse(inputdata[0]) * 1000; //ml로 변환
long k = long.Parse(inputdata[1]);

// 1 : 2 : 4 
if(k*7000 <= x){
    Console.WriteLine(k*7000);
}else if(k*3500 <= x){
    Console.WriteLine(k*3500);
}else if(k*1750 <= x){
    Console.WriteLine(k*1750);
}else{
    Console.WriteLine(k*0);
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

