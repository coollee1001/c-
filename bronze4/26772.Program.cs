// https://www.acmicpc.net/problem/26772

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var data = " @@@   @@@ \n@   @ @   @\n@    @    @\n@         @\n @       @ \n  @     @  \n   @   @   \n    @ @    \n     @     ".Split("\n");

int n = int.Parse(sr.ReadLine());
for(int i=0; i<data.Length; i++){
    for(int j=0; j<n; j++){
        sw.Write(data[i]);
        if(j != n-1) sw.Write(" ");
    }
    sw.WriteLine();
}
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
