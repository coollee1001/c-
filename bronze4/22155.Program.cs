// https://www.acmicpc.net/problem/22155

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var n = int.Parse(sr.ReadLine());
for(int i=0; i<n; i++){
    var nm = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    if((nm[0] <=1 && nm[1] <=2) || (nm[0] <=2 && nm[1] <= 1)) Console.WriteLine("Yes");
    else Console.WriteLine("No");
}

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();