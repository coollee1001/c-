// https://www.acmicpc.net/problem/19698

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var nwhl = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);

int a = (nwhl[1]/nwhl[3])*nwhl[3];
int b = (nwhl[2]/nwhl[3])*nwhl[3];
int result = (a*b)/(nwhl[3]*nwhl[3]);
Console.WriteLine(result<nwhl[0]?result:nwhl[0]);




// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


