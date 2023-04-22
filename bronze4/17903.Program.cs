// https://www.acmicpc.net/problem/17903

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var inputData = sr.ReadLine().Split();
var inputDataArr = Array.ConvertAll(inputData, int.Parse);

Console.WriteLine(inputDataArr[0]<8?"unsatisfactory":"satisfactory");



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


