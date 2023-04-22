// https://www.acmicpc.net/problem/17863

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var inputData = sr.ReadLine();
if(inputData.Substring(0,3).Equals("555")) Console.WriteLine("YES");
else Console.WriteLine("NO");


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


