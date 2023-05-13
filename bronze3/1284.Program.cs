// https://www.acmicpc.net/problem/1284

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

string n = "-1";
while((n = sr.ReadLine())!= "0"){
    var temp = n.ToCharArray();
    
    int sum = 1;
    for(int i=0; i<temp.Length; i++){
        sum += 1;
        if(temp[i] == '0') sum += 4;
        else if(temp[i] == '1') sum += 2;
        else sum +=3;
    }
    sw.WriteLine(sum);
}
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
