// https://www.acmicpc.net/problem/24196

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = sr.ReadLine().ToCharArray();
int index = 0;
while(true){
    Console.Write(data[index]);
    index += data[index] - 'A' + 1;

    if(index > data.Length-1) break;
}
Console.WriteLine();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();