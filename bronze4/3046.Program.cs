//https://www.acmicpc.net/problem/3046

string[] input_N = Console.ReadLine().Split(" ");
int[] int_input_N = new int[input_N.Length];

for(int i=0; i<int_input_N.Length; i++){
    int_input_N[i] = int.Parse(input_N[i]);
}

Console.WriteLine((int_input_N[1]*2)-int_input_N[0]);