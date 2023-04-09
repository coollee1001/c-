//https://www.acmicpc.net/problem/2440

int temp = int.Parse(Console.ReadLine());
for(int i=temp; i>0; i--){
    for(int j=i; j>0; j--){
        Console.Write("*");
    }
    Console.Write("\n");
}