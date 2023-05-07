// https://www.acmicpc.net/problem/27245

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int w = int.Parse(sr.ReadLine());
int l = int.Parse(sr.ReadLine());
int h = int.Parse(sr.ReadLine());

int max = Math.Max(w,l);
int min = Math.Min(w,l);


if(min*2>=max && min>=h*2){
    sw.WriteLine("good");
}else{
    sw.WriteLine("bad");
}
sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
