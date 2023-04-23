// https://www.acmicpc.net/problem/20833

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
ulong sum = 0;
for(int i=1; i<=n; i++){
    sum += (ulong)Math.Pow((double)i, (double)3);
}
Console.WriteLine(sum);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


