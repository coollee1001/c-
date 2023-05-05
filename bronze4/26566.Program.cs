// https://www.acmicpc.net/problem/26566

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
while(n-- != 0){
    var data1 = Array.ConvertAll(sr.ReadLine().Split(" "), double.Parse);
    var data2 = Array.ConvertAll(sr.ReadLine().Split(" "), double.Parse);
    double sliced = (double)data1[0]/data1[1];
    double whole = (double)(Math.PI * Math.Pow(data2[0], 2))/data2[1];
    Console.WriteLine(sliced>whole?"Slice of pizza":"Whole pizza");
}

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
