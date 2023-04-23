// https://www.acmicpc.net/problem/20233

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int[] data = new int[5];
for(int i=0; i<data.Length; i++){
    data[i] = int.Parse(sr.ReadLine());
}
if(30 < data[4]) Console.Write(data[0] + (data[4] - 30) * data[1] * 21);
else Console.Write(data[0]);
Console.Write(" ");
if(45 < data[4]) Console.WriteLine(data[2] + (data[4] - 45) * data[3] * 21);
else Console.WriteLine(data[2]);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


