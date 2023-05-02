// https://www.acmicpc.net/problem/26068

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
int count = 0;
while(n-- != 0){
    if(int.Parse(sr.ReadLine().Replace("D-","")) <= 90) count++;
}
Console.WriteLine(count);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();