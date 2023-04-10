//https://www.acmicpc.net/problem/5543

using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();    
sw.AutoFlush = true;

int n = 3;
int minBugger = 2000, minDrink = 2000;
for(int i=0; i<n; i++){
    int tempBugger = int.Parse(sr.ReadLine());
    if(tempBugger < minBugger) minBugger = tempBugger;
}
n = 2;
for(int i=0; i<n; i++){
    int tempDrink = int.Parse(sr.ReadLine());
    if(tempDrink < minDrink) minDrink = tempDrink;
}
Console.Write(minBugger + minDrink - 50);


// github용 파일 복사
Filecopy fc = new Filecopy(5543);
File.Copy(fc.getThisPath(), fc.getTargetPath());