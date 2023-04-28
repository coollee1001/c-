// https://www.acmicpc.net/problem/24183

StreamReader sr = new StreamReader(Console.OpenStandardInput());

double[] data = Array.ConvertAll(sr.ReadLine().Split(" "), double.Parse);

double c4 = data[0] * 229 * 324 * 2;
double a3 = data[1] * 297 * 420 * 2;
double a4 = data[2] * 210 * 297;

Console.WriteLine("{0:0.000000}",(c4 + a3 + a4) * 0.000001);



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();