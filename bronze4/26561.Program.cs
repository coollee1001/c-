// https://www.acmicpc.net/problem/26561

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
while(n-- != 0){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    data[0] -= data[1]/7;
    data[0] += data[1]/4;
    Console.WriteLine(data[0]);
}

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
