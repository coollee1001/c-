//https://www.acmicpc.net/problem/5358

using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();    
sw.AutoFlush = true;

string names = "";
while((names = sr.ReadLine()) != ""){
    List<char> list = names.ToList();
    for(int i=0; i<list.Count(); i++){
        if(list[i].Equals('i')) list[i] = 'e';
        else if(list[i].Equals('e')) list[i] = 'i';
        else if(list[i].Equals('I')) list[i] = 'E';
        else if(list[i].Equals('E')) list[i] = 'I';
    }
    sb.AppendLine(string.Join("", list));
}

sw.WriteLine(sb.ToString());

// github용 파일 복사
Filecopy fc = new Filecopy(5358);
File.Copy(fc.getThisPath(), fc.getTargetPath());