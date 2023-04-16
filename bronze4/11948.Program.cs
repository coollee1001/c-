//https://www.acmicpc.net/problem/11948

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var jumsu1 = new List<int>();
var jumsu2 = new List<int>();

for(int i=0; i<6; i++){
    if(i < 4){
        jumsu1.Add(int.Parse(sr.ReadLine()));
    }else{
        jumsu2.Add(int.Parse(sr.ReadLine()));
    }
}
jumsu1.Sort(); jumsu1.Reverse();
jumsu2.Sort(); jumsu2.Reverse();

Console.WriteLine(jumsu1[0] + jumsu1[1] + jumsu1[2] + jumsu2[0]);



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();