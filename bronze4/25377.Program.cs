// https://www.acmicpc.net/problem/25377

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
int minData = int.MaxValue;
while(n-- != 0){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    if(data[0]<=data[1]) minData = Math.Min(data[1], minData);
}
Console.WriteLine(minData==int.MaxValue?-1:minData);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();