// https://www.acmicpc.net/problem/26340

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
while(n-- != 0){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    Console.WriteLine("Data set: {0} {1} {2}", data[0], data[1], data[2]);
    for(int i=0; i<data[2]; i++){
        if(data[1] < data[0]) data[0] /= 2;
        else data[1] /= 2;
    }
    Console.WriteLine("{0} {1}", Math.Max(data[0], data[1]), Math.Min(data[0], data[1]));
    Console.WriteLine();
}


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();