// https://www.acmicpc.net/problem/17388

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var inputData = sr.ReadLine().Split();
var inputDataArr = Array.ConvertAll(inputData, int.Parse);

int sum = inputDataArr[0] + inputDataArr[1] + inputDataArr[2];
if(100 <= sum) Console.WriteLine("OK");
else{
    var minData = Math.Min(Math.Min(inputDataArr[0], inputDataArr[1]), inputDataArr[2]);
    var result = "";
    for(int i=0; i<inputDataArr.Length; i++){
        if(minData == inputDataArr[i]){
            switch(i){
                case 0: result = "Soongsil"; break;
                case 1: result = "Korea"; break;
                case 2: result = "Hanyang"; break;
            }
            break;
        }
    }
    Console.WriteLine(result);
}

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


