// https://www.acmicpc.net/problem/26530

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
while(n-- != 0){
    int m = int.Parse(sr.ReadLine());
    double sum = 0.0d;
    while(m-- != 0){
        var data = sr.ReadLine().Split(" ");
        sum += double.Parse(data[1]) * double.Parse(data[2]);
    }
    Console.WriteLine("${0:0.00}", sum);
}

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
