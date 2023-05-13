// https://www.acmicpc.net/problem/1247

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

for(int i=0; i<3; i++){
    int n = int.Parse(sr.ReadLine());
    long sum = 0, overflow = 0;
    string result = "";
    while(n-- != 0){
        long input = long.Parse(sr.ReadLine());
        if(input > 0 && long.MaxValue - input < sum) overflow++;
        else if(input < 0 && long.MinValue - input > sum) overflow--;
        sum += input;
    }
    if(overflow > 0) result = "+";
    else if(overflow < 0) result = "-";
    else{
        if(sum > 0) result = "+";
        else if(sum <0) result = "-";
        else result = "0";
    }
    sw.WriteLine(result);
}
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
