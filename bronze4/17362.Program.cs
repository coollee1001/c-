// https://www.acmicpc.net/problem/17362

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var inputData = long.Parse(sr.ReadLine());
inputData %= 8;
Console.WriteLine(inputData > 5 || inputData == 0?(10-inputData)%8:inputData);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


