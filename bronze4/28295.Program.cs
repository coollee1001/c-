// https://www.acmicpc.net/problem/28295

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int idx = 0;
string s = "NESW";
for(int i=0; i<10; i++){
    int data = int.Parse(sr.ReadLine());
    idx += data;
}
idx %= 4;
sw.WriteLine(s[idx]);
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();