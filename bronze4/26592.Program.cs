// https://www.acmicpc.net/problem/26592

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
while(n-- != 0){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), double.Parse);
    Console.WriteLine("The height of the triangle is {0:0.00} units", (data[0]*2)/data[1]);
}

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
