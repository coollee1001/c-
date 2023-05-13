// https://www.acmicpc.net/problem/27890

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
for(int i=0; i<data[1]; i++){
    if(data[0]%2 == 0) data[0] = (data[0]/2)^6;
    else data[0] = (data[0]*2)^6;
}
sw.WriteLine(data[0]);
sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
