// https://www.acmicpc.net/problem/3460

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int testCase = int.Parse(sr.ReadLine());
while(testCase-- != 0){
    var data = int.Parse(sr.ReadLine());
    // 10진수를 2진수로 변환
    String binary = Convert.ToString(data, 2);
    // 2진수에서 마지막 1의 위치 파악하기(index 순서는 반대로)
    int lastIndex = binary.IndexOf("1");
    int index = -1;
    for(int i=binary.Length-1; i>=0; i--){
        index++;
        if(binary.Substring(i, 1) != "1") {
            continue;
        }else{
            if(i == lastIndex){
                sw.WriteLine(String.Format("{0}", index));
            }else{
                sw.Write(String.Format("{0} ", index));
            }
        }
    }
}
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
