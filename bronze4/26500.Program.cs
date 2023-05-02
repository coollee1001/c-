// https://www.acmicpc.net/problem/26500

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
while(n-- != 0){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), double.Parse);
    Console.WriteLine("{0:0.0}",Math.Round(Math.Abs(data[0]-data[1]), 1));
}

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
