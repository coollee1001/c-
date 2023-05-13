// https://www.acmicpc.net/problem/2455

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int max = -1000000000;
int sum = 0;

for(int i=0; i<4; i++){
    var data = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    sum -= data[0];
    sum += data[1];
    if(max<sum) max = sum;
}
sw.WriteLine(max);
sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
