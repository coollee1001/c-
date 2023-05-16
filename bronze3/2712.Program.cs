// https://www.acmicpc.net/problem/2712

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int testCase = int.Parse(sr.ReadLine());
while(testCase-- != 0){
    var data = sr.ReadLine().Split(" ");
    string unit = null;
    double n = double.Parse(data[0]);
    if(data[1].Equals("kg") || data[1].Equals("lb")){
        n = data[1].Equals("kg")?n * 2.2046: n * 0.4536;
        unit = data[1].Equals("kg")?"lb":"kg";
    }else if(data[1].Equals("l") || data[1].Equals("g")){
        n = data[1].Equals("l")?n * 0.2642:n * 3.7854;
        unit = data[1].Equals("l")?"g":"l";
    }
    sw.WriteLine("{0:0.0000} {1}",n, unit);
}
sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
