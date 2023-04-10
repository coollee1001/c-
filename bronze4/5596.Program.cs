//https://www.acmicpc.net/problem/5596

using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();    
sw.AutoFlush = true;

int n = 2, sum = 0;
for(int i=0; i<n; i++){
    string[] temp = sr.ReadLine().Split(" ");
    int tempResult = 0;
    for(int j=0; j<temp.Length; j++){
        tempResult += int.Parse(temp[j]);
    }
    if(sum < tempResult) sum = tempResult;
}
Console.WriteLine(sum);

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