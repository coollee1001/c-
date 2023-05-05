// https://www.acmicpc.net/problem/26742

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = sr.ReadLine().ToCharArray();
int[] ab = new int[2];
for(int i=0; i<data.Length; i++){
    if(data[i] == 'B') {
        ab[0] += 1;
    }else{
        ab[1] += 1;
    }
}
Console.WriteLine("{0}", (ab[0]/2)+(ab[1]/2));



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
