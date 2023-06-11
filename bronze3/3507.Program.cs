// https://www.acmicpc.net/problem/3507

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
int cnt = 0;

if(n <= 198){
    for(int i=1; i<100; i++){
        for(int j=1; j<100; j++){
            if(i+j == n){
                cnt += 1;
            }
        }
    }
}
sw.WriteLine(cnt);
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
