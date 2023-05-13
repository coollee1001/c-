// https://www.acmicpc.net/problem/2490

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

for(int i=0; i<3; i++){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    int sum = 0;
    for(int j=0; j<data.Length; j++){
        sum += data[j];
    }
    sw.WriteLine(sum==3?"A":sum==2?"B":sum==1?"C":sum==4?"E":"D");
}
sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
