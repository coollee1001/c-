// https://www.acmicpc.net/problem/19944

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var nm = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
bool newbie = (nm[1]==1) || (nm[1] == 2);
if(newbie){
    Console.WriteLine("NEWBIE!");
}else if((!newbie) && nm[1]<=nm[0]){
    Console.WriteLine("OLDBIE!");
}else{
    Console.WriteLine("TLE!");
}




// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


