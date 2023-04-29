// https://www.acmicpc.net/problem/25494

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());

while(n-- != 0){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    Console.WriteLine(Math.Min(data[0], Math.Min(data[1], data[2])));
}



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();