//https://www.acmicpc.net/problem/14470

StreamReader sr = new StreamReader(Console.OpenStandardInput());
int[] inputData = new int[5];
for(int i=0; i<inputData.Length; i++){
    inputData[i] = int.Parse(sr.ReadLine());
}
int second = 0;
if(inputData[0] < 0) {
    second += Math.Abs(inputData[0]) * inputData[2];
    second += inputData[3];
    second += inputData[1] * inputData[4];
}else{
    second = (inputData[1] - inputData[0]) * inputData[4];
}

Console.WriteLine(second);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
