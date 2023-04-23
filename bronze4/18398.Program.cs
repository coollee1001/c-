// https://www.acmicpc.net/problem/18398

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int t = int.Parse(sr.ReadLine());
for(int i=0; i<t; i++){
    int n = int.Parse(sr.ReadLine());
    for(int j=0; j<n; j++){
        var ab = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
        Console.WriteLine("{0} {1}", ab[0]+ab[1], ab[0]*ab[1]);
    }
}


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


