// https://www.acmicpc.net/problem/2061

using System.Numerics;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var data = sr.ReadLine().Split(" ");
BigInteger a = BigInteger.Parse(data[0]);
BigInteger b = BigInteger.Parse(data[1]);
bool flag = true;
for(int i=2; i<b; i++){
    if(a%i==0){
        sw.WriteLine("BAD {0}", i);
        flag = !flag;
        break;
    }
}
if(flag) sw.WriteLine("GOOD");
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
