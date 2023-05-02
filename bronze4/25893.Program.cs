// https://www.acmicpc.net/problem/25893

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
while(n-- != 0){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    Console.WriteLine("{0} {1} {2}", data[0], data[1], data[2]);
    Array.Sort(data);
    int a = data[0];    int b = data[1];    int c = data[2];
    if(10<=a && 10<=b && 10<=c) Console.WriteLine("triple-double");
    else if(10<=b && 10<=c) Console.WriteLine("double-double");
    else if(a<10 && b<10 && c<10) Console.WriteLine("zilch");
    else Console.WriteLine("double");
    Console.WriteLine();
}

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();