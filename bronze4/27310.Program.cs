// https://www.acmicpc.net/problem/27310

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var data = sr.ReadLine().ToCharArray();
int sum = data.Length;
int colon = 0, underbar = 0;
for(int i=0; i<data.Length; i++){
    if(data[i] == ':') colon++;
    if(data[i] == '_') underbar++;
}
sw.WriteLine(sum+colon+underbar*5);
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
