//https://www.acmicpc.net/problem/2845

string[] input_N = Console.ReadLine().Split(" ");
int[] int_input_N = new int[input_N.Length];

for(int i=0; i<int_input_N.Length; i++){
    int_input_N[i] = int.Parse(input_N[i]);
}

input_N = Console.ReadLine().Split(" ");

for(int i=0; i<input_N.Length; i++){
    Console.Write(int.Parse(input_N[i]) - (int_input_N[0]*int_input_N[1]));
    if(i+1 != input_N.Length) Console.Write(" ");
}