// https://www.acmicpc.net/problem/4435

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

// 각 종족의 점수 배열
int[] gandalfArray = {1,2,3,3,4,10};
int[] sauronArray = {1,2,2,2,3,5,10};

// 전투 개수
int n = int.Parse(sr.ReadLine());
for(int i=1; i<=n; i++){

    // 데이터 입력
    var gandalf = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
    var sauron = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);

    // 초기화
    int gsum = 0;
    int ssum = 0;
    string result;

    // 간달프 군대 점수
    for(int j=0; j<gandalf.Length; j++){
        gsum += gandalf[j] * gandalfArray[j];
    }

    // 사우론 군대 점수
    for(int j=0; j<sauron.Length; j++){
        ssum += sauron[j] * sauronArray[j];
    }

    // 어느 쪽이 이기는지 판단
    if(gsum == ssum){
        result = "No victor on this battle field";
    }else if(gsum < ssum){
        result = "Evil eradicates all trace of Good";
    }else{
        result  = "Good triumphs over Evil";
    }

    // 결과 출력
    sw.WriteLine(String.Format("Battle {0}: {1}", i, result));
}
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();