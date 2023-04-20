// https://www.acmicpc.net/problem/16199

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var birthday = sr.ReadLine().Split(" ");
var today = sr.ReadLine().Split(" ");
var birthdayArr = Array.ConvertAll(birthday, int.Parse);
var todayArr = Array.ConvertAll(today, int.Parse);
int year1 = 0, year2 = 0, year3 = 0;
if(birthdayArr[1] < todayArr[1]){
    year1 =  todayArr[0] - birthdayArr[0];
}else if(birthdayArr[1] == todayArr[1] && birthdayArr[2] <= todayArr[2]){
    year1 = todayArr[0] - birthdayArr[0];
}else{
    year1 = todayArr[0] - birthdayArr[0] - 1;
}
year2 = todayArr[0] - birthdayArr[0] + 1;
year3 = todayArr[0] - birthdayArr[0];
Console.WriteLine(year1+"\n"+year2+"\n"+year3);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

