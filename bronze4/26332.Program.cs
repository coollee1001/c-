// https://www.acmicpc.net/problem/26332

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
while(n-- != 0){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    Console.WriteLine("{0} {1}", data[0], data[1]);
    Console.WriteLine("{0}", 1<data[0]?(data[1]*data[0])-((data[0]-1)*2):data[1]);
}


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();