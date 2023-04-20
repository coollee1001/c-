//https://www.acmicpc.net/problem/15873

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;

var inputData = sr.ReadLine();
int[] data = new int[inputData.Length];
for(int i=0; i<inputData.Length; i++){
    int temp = int.Parse(inputData.Substring(i, 1));
    if(temp == 0) data[i-1] = 10;
    else data[i] = temp;
}
int sum = 0;
for(int i=0; i<data.Length; i++){
    sum += data[i];
}
sw.WriteLine(sum);
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

