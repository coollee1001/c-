//https://www.acmicpc.net/problem/15610

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;

long inputData = long.Parse(sr.ReadLine());
double powInputData = Math.Sqrt(inputData);
sw.Write(String.Format("{0:0.000000}", powInputData * 4));

sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

