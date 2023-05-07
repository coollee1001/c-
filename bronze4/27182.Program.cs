// https://www.acmicpc.net/problem/27182

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
if(data[0] >= 8){
    sw.WriteLine(data[0]-7);
}else{
    sw.WriteLine(data[1]+7);
}
sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
