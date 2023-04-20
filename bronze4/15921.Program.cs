// https://www.acmicpc.net/problem/15921

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
if(n == 0){
    Console.WriteLine("divide by zero");
}else{
    Console.WriteLine("1.00");
}


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

