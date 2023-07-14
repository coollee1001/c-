// https://www.acmicpc.net/problem/28281

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

// n x
var nxData = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
// socks 
var nData = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
int min = int.MaxValue;
for(int i=0; i<nData.Length-1; i++)
{
    min = Math.Min(min, nData[i] * nxData[1] + nData[i+1] * nxData[1] );
}
sw.WriteLine(min);
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();