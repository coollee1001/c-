// https://www.acmicpc.net/problem/25640

StreamReader sr = new StreamReader(Console.OpenStandardInput());

string myMbti = sr.ReadLine();
int people = int.Parse(sr.ReadLine());
int count = 0;
while(people-- != 0){
    if(sr.ReadLine().Equals(myMbti)) count++;
}
Console.WriteLine(count);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();