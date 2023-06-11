// https://www.acmicpc.net/problem/4153

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

while(true){
    var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    
    // 종료
    if(data[0] == 0 && data[1] == 0 && data[2] == 0) {
        break;
    }

    // 정렬
    Array.Sort(data);

    // 직각삼각형 판단
    if(Math.Pow(data[0], 2) + Math.Pow(data[1], 2) == Math.Pow(data[2], 2)){
        sw.WriteLine("right");
    }else{
        sw.WriteLine("wrong");
    }
}

sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
