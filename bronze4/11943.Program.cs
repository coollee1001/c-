//https://www.acmicpc.net/problem/11943

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var first = sr.ReadLine().Split(" ");
var second = sr.ReadLine().Split(" ");
var firstInt = new List<int>();
var secondInt = new List<int>();
int a = 0, b = 0;
for(int i=0; i<first.Length; i++) {
    firstInt.Add(int.Parse(first[i]));
    secondInt.Add(int.Parse(second[i]));
}
a = firstInt[0] + secondInt[1];
b = firstInt[1] + secondInt[0];

if(a<b) Console.WriteLine(a);
else Console.WriteLine(b);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();