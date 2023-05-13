// https://www.acmicpc.net/problem/27880

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int sum = 0;
for(int i=0; i<4; i++){
    var data = sr.ReadLine().Split(" ");
    if(data[0].Equals("Stair")) sum += int.Parse(data[1]) * 17;
    else sum += int.Parse(data[1]) * 21;
}
sw.WriteLine(sum);
sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
