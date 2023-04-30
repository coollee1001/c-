// https://www.acmicpc.net/problem/25881

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
var people = int.Parse(sr.ReadLine());
int index = 0;
int[] kwhData = new int[people];
while(people-- != 0){
    kwhData[index++] = int.Parse(sr.ReadLine());
}
for(int i=0; i<kwhData.Length; i++){
    int khw1000 = (double)(kwhData[i]/1000.0)<=1?kwhData[i]*data[0]:1000*data[0];
    int khw1000Over = 0;
    if(khw1000 == 1000*data[0]){
        khw1000Over = (kwhData[i]-1000)*data[1];
    }    
    Console.WriteLine("{0} {1}", kwhData[i], khw1000+khw1000Over);
}

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();