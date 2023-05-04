// https://www.acmicpc.net/problem/26546

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
while(n-- != 0){
    var data = sr.ReadLine().Split(" ");
    Console.WriteLine(data[0].Substring(0, int.Parse(data[1])) + data[0].Substring(int.Parse(data[2])));
}



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
