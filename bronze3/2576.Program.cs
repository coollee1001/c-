// https://www.acmicpc.net/problem/2576

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int sum = -1;
int min = 100;
for(int i=0; i<7; i++){
    int temp = 0;
    if((temp = int.Parse(sr.ReadLine()))%2 != 0){
        sum += temp;
        if(temp < min) min = temp;
    } 
}
if(sum == -1){
    sw.WriteLine(sum);
}else{
    sw.WriteLine(sum+1);
    sw.WriteLine(min);
}
sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
