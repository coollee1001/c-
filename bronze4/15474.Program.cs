//https://www.acmicpc.net/problem/15474

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;

var inputData = sr.ReadLine().Split(" ");
var inputDataInt = Array.ConvertAll(inputData, int.Parse);

int a = (int)Math.Ceiling((double)inputDataInt[0]/inputDataInt[1]) * inputDataInt[2];
int b = (int)Math.Ceiling((double)inputDataInt[0]/inputDataInt[3]) * inputDataInt[4];

sw.WriteLine(a<b?a:b);
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

