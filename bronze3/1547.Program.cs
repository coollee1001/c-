// https://www.acmicpc.net/problem/1547

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
int[] arr = new int[4];
arr[1] = 1;
for(int i=0; i<n ;i++){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    int tmp = arr[data[0]];
    arr[data[0]] = arr[data[1]];
    arr[data[1]] = tmp;
}
for(int i=0; i<arr.Length; i++){
    if(arr[i] == 1) sw.WriteLine(i);
}

sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
