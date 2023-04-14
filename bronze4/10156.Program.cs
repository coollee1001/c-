//https://www.acmicpc.net/problem/10156

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var inputData = sr.ReadLine()?.Split(" ");
var inputIntData = new List<int>();
for(int i=0; i<inputData.Length; i++){
    inputIntData.Add(int.Parse(inputData![i]));
}
int sum = (inputIntData[0] * inputIntData[1]) - inputIntData[2];
Console.Write("{0}", sum < 0?0:sum);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

