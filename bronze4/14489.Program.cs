//https://www.acmicpc.net/problem/14489

StreamReader sr = new StreamReader(Console.OpenStandardInput());
var account = sr.ReadLine().Split(" ");
var accountArr = Array.ConvertAll(account, int.Parse);

var chicken = int.Parse(sr.ReadLine());
var accountSum = accountArr[0] + accountArr[1];
if(accountSum < chicken * 2){
    Console.WriteLine(accountSum);
}else{
    Console.WriteLine(accountSum - (chicken * 2));
}



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
