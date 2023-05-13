// https://www.acmicpc.net/problem/2547

using System.Numerics;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
for(int i=0; i<n; i++){
    sr.ReadLine();
    int student = int.Parse(sr.ReadLine());
    BigInteger sum = new BigInteger();
    for(int j=0; j<student; j++){
        sum += BigInteger.Parse(sr.ReadLine());
    }
    if(sum%student == 0) sw.WriteLine("YES");
    else sw.WriteLine("NO");
}

sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
