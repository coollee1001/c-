// https://www.acmicpc.net/problem/2721

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int testCase = int.Parse(sr.ReadLine());
while(testCase-- != 0){
    var data = int.Parse(sr.ReadLine());
    int w = 0;
    for(int i=1; i<=data; i++){
        int sum = 0;
        for(int j=1; j<=i+1; j++){
            sum += j;
        }
        w += i * sum;
    }
    sw.WriteLine(w);
}
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
