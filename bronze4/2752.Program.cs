//https://www.acmicpc.net/problem/2752

string[] input_threeInt = Console.ReadLine().Split(" ");
int[] input_sort = new int[input_threeInt.Length];

for(int i=0; i<input_threeInt.Length; i++){
    input_sort[i] = int.Parse(input_threeInt[i]);
}

Array.Sort(input_sort);

for(int i=0; i<input_sort.Length; i++){
    Console.Write(input_sort[i]);
    if(i != input_sort.Length-1) Console.Write(" ");
}
