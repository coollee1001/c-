//https://www.acmicpc.net/problem/15128

// 삼각형의 넓이가 정수 ==> (p1 * p2) % (q1 * q2 * 2) == 0
StreamReader sr = new StreamReader(Console.OpenStandardInput());
var inputData = sr.ReadLine().Split(" ");
var inputDataArr = Array.ConvertAll(inputData, long.Parse);

long a = inputDataArr[0] * inputDataArr[2];
long b = inputDataArr[1] * inputDataArr[3] * 2;

Console.WriteLine( a % b == 0?1:0);



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
