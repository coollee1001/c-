// https://www.acmicpc.net/problem/25932

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
while(n-- != 0){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9]);
    if(data.Contains(18) && data.Contains(17)) Console.WriteLine("both");
    else if(data.Contains(18)) Console.WriteLine("mack");
    else if(data.Contains(17)) Console.WriteLine("zack");
    else Console.WriteLine("none");
    Console.WriteLine();
}

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();