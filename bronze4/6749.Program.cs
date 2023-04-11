//https://www.acmicpc.net/problem/6749

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int[] children = new int[2];
for(int i=0; i<children.Length; i++){
    children[i] = int.Parse(sr.ReadLine());
}
Console.WriteLine((children[1] - children[0]) + children[1]);



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
