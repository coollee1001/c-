// https://www.acmicpc.net/problem/18198

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var inputData = sr.ReadLine();
int a = 0, b = 0;
for(int i=0; i<inputData.Length; i+=2){
    if(char.Parse(inputData.Substring(i,1)) == 'A') a += int.Parse(inputData.Substring(i+1,1));
    else b += int.Parse(inputData.Substring(i+1,1));
}
Console.WriteLine(a<b?"B":"A");

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


