// https://www.acmicpc.net/problem/2720

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int testCase = int.Parse(sr.ReadLine());
int[] coin = {25, 10, 5, 1};
while(testCase-- != 0){
    var data = int.Parse(sr.ReadLine());
    for(int i=0; i<coin.Length; i++){
        if(i != coin.Length-1){
            sw.Write("{0} ", data/coin[i]); 
        }else{
            sw.WriteLine("{0}", data/coin[i]);
        }
        data %= coin[i];
    }
}
sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
