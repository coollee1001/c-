//https://www.acmicpc.net/problem/11365

StreamReader sr = new StreamReader(Console.OpenStandardInput());

string temp = "";
while((temp = sr.ReadLine()) != "END"){
    for(int i=temp.Length-1; i>=0; i--){
        Console.Write(temp[i]);
    }
    Console.WriteLine();
}

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();