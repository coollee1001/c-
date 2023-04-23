// https://www.acmicpc.net/problem/20867

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var msg = Array.ConvertAll(sr.ReadLine().Split(" "), double.Parse);
var ab = Array.ConvertAll(sr.ReadLine().Split(" "), double.Parse);
var lr = Array.ConvertAll(sr.ReadLine().Split(" "), double.Parse);

var lwait = lr[0]/ab[0];
var rwait = lr[1]/ab[1];

var ls = msg[0]%msg[2]==0?(msg[0]/msg[2])+1:msg[0]/msg[2];
var rs = msg[0]%msg[1]==0?(msg[0]/msg[1])+1:msg[0]/msg[1];

var result = "latmask";
if(ls+lwait < rs+rwait) result = "friskus";

Console.WriteLine(result);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


