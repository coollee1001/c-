// https://www.acmicpc.net/problem/2476

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
int max = 0;
for(int i=0; i<n; i++){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    int temp = 0;
    Array.Sort(data);
    if(data[0]==data[1] && data[0]==data[2]) {
        temp = 10000+data[0]*1000;
    }
    else if(data[0]!=data[1] && data[0]!=data[2] && data[1]!=data[2]){
        temp = data[2]*100;
    } 
    else {
        for(int j=0; j<data.Length-1; j++){
            if(data[j] == data[j+1]){
                temp = 1000 + data[j] * 100;
            } 
        }
    }
    if(max<temp) max = temp;
}
sw.WriteLine(max);

sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
