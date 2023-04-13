//https://www.acmicpc.net/problem/9782

using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
sw.AutoFlush = true;
StringBuilder sb = new StringBuilder();

uint count = 1;
while(true){
    var inputData = sr.ReadLine()?.Split(" ");
    var n = int.Parse(inputData![0]);
    if(n == 0) break;

    var inputIntData = new List<int>(n);
    for(uint i=0; i<n; i++){
       inputIntData.Add(int.Parse(inputData![i+1]));
    }
    double sum = 0.0d;
    if(n % 2 == 0){ //짝수라면
        sum = (inputIntData[(n/2)-1] + inputIntData[(n/2)])*0.5;
    }else{
        sum = (inputIntData[((n+1)/2)-1]);
    }
    sb.AppendLine(String.Format("Case {0}: {1:0.0}", count++, sum));
}
sw.WriteLine(sb.ToString());


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
