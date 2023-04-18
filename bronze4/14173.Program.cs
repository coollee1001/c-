//https://www.acmicpc.net/problem/14173

StreamReader sr = new StreamReader(Console.OpenStandardInput());
var first = sr.ReadLine().Split(" ");
var second = sr.ReadLine().Split(" ");

int[] min = {99, 99};
int[] max = {0, 0};

for(int i=0; i<first.Length; i+=2){
    if(int.Parse(first[i]) < min[0]) min[0] = int.Parse(first[i]);
    if(int.Parse(first[i+1]) < min[1]) min[1] = int.Parse(first[i+1]);
    if(max[0] < int.Parse(first[i])) max[0] = int.Parse(first[i]);
    if(max[1] < int.Parse(first[i+1])) max[1] = int.Parse(first[i+1]);
    
    if(int.Parse(second[i]) < min[0]) min[0] = int.Parse(second[i]);
    if(int.Parse(second[i+1]) < min[1]) min[1] = int.Parse(second[i+1]);
    if(max[0] < int.Parse(second[i])) max[0] = int.Parse(second[i]);
    if(max[1] < int.Parse(second[i+1])) max[1] = int.Parse(second[i+1]);
}

int length = Math.Max(max[0]-min[0], max[1]-min[1]);
Console.WriteLine("{0}", length * length);


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
