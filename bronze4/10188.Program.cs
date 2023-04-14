//https://www.acmicpc.net/problem/10188

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var n = int.Parse(sr.ReadLine());
for(int i = 0; i < n; i++){
    var sets = sr.ReadLine().Split(" ");
    for(int x = 0; x < int.Parse(sets[1]); x++){
        for(int y = 0; y < int.Parse(sets[0]); y++){
            Console.Write("X");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

