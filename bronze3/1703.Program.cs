// https://www.acmicpc.net/problem/1703

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

while(true){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    int n = data[0];
    if(n == 0) break;
    int total = 1;    
    for(int i=1; i<data.Length-1; i+=2){
        total *= data[i];
        total -= data[i+1];
    }
    sw.WriteLine(total);
}
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
