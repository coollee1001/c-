//https://www.acmicpc.net/problem/6916

StreamReader sr = new StreamReader(Console.OpenStandardInput());

string[] list = {
    " * * *\n*     *\n*     *\n*     *\n\n*     *\n*     *\n*     *\n * * *",
    "\n      *\n      *\n      *\n\n      *\n      *\n      *",
    " * * *\n      *\n      *\n      *\n * * *\n*\n*\n*\n * * * ",
    " * * *\n      *\n      *\n      *\n * * *\n      *\n      *\n      *\n * * *",
    "\n*     *\n*     *\n*     *\n * * *\n      *\n      *\n      *\n",
    " * * *\n*\n*\n*\n * * *\n      *\n      *\n      *\n * * *",
    " * * *\n*\n*\n*\n * * *\n*     *\n*     *\n*     *\n * * *",
    " * * *\n      *\n      *\n      *\n\n      *\n      *\n      *",
    " * * *\n*     *\n*     *\n*     *\n * * *\n*     *\n*     *\n*     *\n * * *",
    " * * *\n*     *\n*     *\n*     *\n * * *\n      *\n      *\n      *\n * * *"};
int n = int.Parse(sr.ReadLine());
Console.WriteLine(list[n]);


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

