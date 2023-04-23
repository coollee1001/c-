// https://www.acmicpc.net/problem/18691

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
for(int i=0; i<n; i++){
    var abc = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    var candy = abc[2] - abc[1];
    int kilometers = 0;
    if(abc[0] == 1)  kilometers = candy;
    else if(abc[0] == 2) kilometers = candy * 3;
    else kilometers = candy * 5;

    if(kilometers <= 0) Console.WriteLine("0");
    else Console.WriteLine(kilometers);
}



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


