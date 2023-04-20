// https://www.acmicpc.net/problem/16017

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int one = int.Parse(sr.ReadLine());
int two = int.Parse(sr.ReadLine());
int three = int.Parse(sr.ReadLine());
int four = int.Parse(sr.ReadLine());

if((one == 8 || one == 9) && two == three && (four == 8 || four == 9)){
    Console.WriteLine("ignore");
}else{
    Console.WriteLine("answer");
}


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

