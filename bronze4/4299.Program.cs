//https://www.acmicpc.net/problem/4299

using System.Text;

string[] temp;
int[] int_temp;
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;

temp = sr.ReadLine().Split(" ");
int_temp = new int[temp.Length];

for(int i=0; i<temp.Length; i++){
    int_temp[i] = int.Parse(temp[i]);
}

//계산
int x = (int_temp[0] + int_temp[1])/2;
int y = (int_temp[1] - x)*-1;
if((x+y) == int_temp[0] && (x-y) == int_temp[1] && 0 <= x && 0 <= y)
sw.WriteLine("{0} {1}", (x < y)?y:x, (x<y)?x:y);
else sw.WriteLine(-1);
