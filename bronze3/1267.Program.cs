// https://www.acmicpc.net/problem/1267

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
int y = 0, m = 0;
var x = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
while(n-- != 0){
    y += ((x[n]/30)+1)*10;
    m += ((x[n]/60)+1)*15;
}
if(y == m) sw.WriteLine("Y M {0}", y);
else sw.WriteLine("{0} {1}",m<y?"M":"Y", m<y?m:y);

sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
