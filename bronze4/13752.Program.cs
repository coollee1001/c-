// https://www.acmicpc.net/problem/13752

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int testCase = int.Parse(sr.ReadLine());
while(testCase-- != 0){
    var data = int.Parse(sr.ReadLine());
    for(int i=0; i<data; i++){
        sw.Write("=");
    }
    sw.WriteLine();
}
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
