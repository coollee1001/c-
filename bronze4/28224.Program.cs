// https://www.acmicpc.net/problem/28224

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int testCase = int.Parse(sr.ReadLine());
int sum = 0;
while(testCase-- != 0){
    var data = int.Parse(sr.ReadLine());
    sum += data;
}
sw.WriteLine(String.Format("{0}", sum));
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
