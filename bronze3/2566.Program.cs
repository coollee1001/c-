// https://www.acmicpc.net/problem/2566

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int max = -1;
int[] array = new int[2];
for(int i=0; i<9; i++){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    for(int j=0; j<9; j++){
        if(max<data[j]) {
            max = data[j];
            array[0] = i+1; array[1] = j+1;
        }
    }
}
sw.WriteLine(max);
sw.WriteLine("{0} {1}",array[0], array[1]);

sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
