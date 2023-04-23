// https://www.acmicpc.net/problem/20839

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var limit = Array.ConvertAll(sr.ReadLine().Split(" "), double.Parse);
var student = Array.ConvertAll(sr.ReadLine().Split(" "), double.Parse);

var result = "E";
if(limit[0] <= student[0] && limit[1] <= student[1] && limit[2] <=student[2]) result = "A";
else if(limit[0]/2 <= student[0] && limit[1] <= student[1] && limit[2] <= student[2]) result = "B";
else if(limit[1] <= student[1] && limit[2] <= student[2]) result = "C";
else if(limit[1]/2 <= student[1] && limit[2]/2 <= student[2]) result="D";

Console.WriteLine(result);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


