//https://www.acmicpc.net/problem/8558

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
long sum = 1;
for(int i=1; i<=n; i++){
    sum *= i;
}
string strSum = sum.ToString();
Console.WriteLine(strSum[strSum.Length-1]);

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

