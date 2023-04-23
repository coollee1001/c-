// https://www.acmicpc.net/problem/20673

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int p = int.Parse(sr.ReadLine());
int q = int.Parse(sr.ReadLine());

Console.WriteLine(p<=50&&q<=10?"White":q>30?"Red":"Yellow");


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


