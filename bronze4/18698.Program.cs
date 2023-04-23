// https://www.acmicpc.net/problem/18698

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
for(int i=0; i<n; i++){
    var abc = sr.ReadLine().ToCharArray();
    int count = 0;
    for(int j=0; j<abc.Length; j++){
        if(abc[j] == 'U') count++;
        else break;
    }
    Console.WriteLine(count);
}



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


