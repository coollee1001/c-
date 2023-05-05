// https://www.acmicpc.net/problem/26731

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = sr.ReadLine().ToCharArray();
Array.Sort(data);
for(int i=0; i<data.Length; i++){
    if(data[i] != 'A'+i) {
        Console.WriteLine(char.ConvertFromUtf32('A'+i));
        break;
    }
    if(data[i] == 'Y') {
        Console.WriteLine("Z");
    }
}



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
