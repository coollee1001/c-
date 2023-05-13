// https://www.acmicpc.net/problem/27918

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
int[] data = new int[2];
for(int i=0; i<n; i++){
    if(Math.Abs(data[0]-data[1]) == 2) break;
    if(sr.ReadLine().Equals("D")) data[0]++;
    else data[1]++;
}
sw.WriteLine("{0}:{1}",data[0],data[1]);
sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
