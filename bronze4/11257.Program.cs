//https://www.acmicpc.net/problem/11257

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var n = int.Parse(sr.ReadLine());
var resultInfo = new List<string[]>();
for(int i=0; i<n; i++){
    var info = new string[3];
    var inputInfo = sr.ReadLine().Split(" ");
    var strategy = int.Parse(inputInfo[1]);
    var management = int.Parse(inputInfo[2]);
    var technology = int.Parse(inputInfo[3]);
    info[0] = inputInfo[0];
    info[1] = (strategy + management + technology).ToString();
    info[2] = "PASS";
    if(int.Parse(info[1]) < 55) info[2] = "FAIL";
    else{
        // 최소점수 초과?
        if(strategy < 11) info[2] = "FAIL";
        if(management < 8) info[2] = "FAIL";
        if(technology < 12) info[2] = "FAIL";
    }
    Console.WriteLine("{0} {1} {2}", info[0], info[1], info[2]);
}


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

