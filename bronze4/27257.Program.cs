// https://www.acmicpc.net/problem/27257

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var str = sr.ReadLine();
int count = 0;
for(int i = 0; i<str.Length; i++){
    if(str[i] == '0') count++;
}
for(int i=str.Length-1; i!=0; i--){
    if(str[i] == '0') count--;
    else break;
}
sw.WriteLine(count);
sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
