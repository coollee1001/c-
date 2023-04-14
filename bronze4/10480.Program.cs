//https://www.acmicpc.net/problem/10480

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var n = int.Parse(sr.ReadLine());
for(int i = 0; i < n; i++){
    var x = int.Parse(sr.ReadLine());
    var result = "";
    if(x%2 == 0) result = "even";
    else result = "odd";
    Console.WriteLine("{0} is {1}", x, result);
}


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

