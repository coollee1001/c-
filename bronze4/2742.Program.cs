//https://www.acmicpc.net/problem/2742

using System.Text;

int input_N = int.Parse(Console.ReadLine());
StringBuilder answer = new StringBuilder();

for(int i=input_N; i>0; i--){
    answer.AppendLine(i.ToString());
}
Console.WriteLine(answer);