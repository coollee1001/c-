// https://www.acmicpc.net/problem/26350

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
while(n-- != 0){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    Console.Write("Denominations: ");
    string result = "Good";
    for(int i=0; i<data[0]; i++){
        Console.Write(data[i+1] + " ");
    }
    int prevData = data[1];
    for(int i=1; i<data[0]; i++){
        if(data[i+1] < prevData*2) {
            result = "Bad";
            break;
        }
        prevData = data[i+1];
    }
    Console.WriteLine("{0} coin denominations!", result);
    Console.WriteLine();
}


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();