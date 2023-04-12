//https://www.acmicpc.net/problem/6841

using System.Collections;

StreamReader sr = new StreamReader(Console.OpenStandardInput());

Hashtable hash = new Hashtable();
hash.Add("CU", "see you");
hash.Add(":-)", "I’m happy");
hash.Add(":-(", "I’m unhappy");
hash.Add(";-)", "wink");
hash.Add(":-P", "stick out my tongue");
hash.Add("(~.~)", "sleepy");
hash.Add("TA", "totally awesome");
hash.Add("CCC", "Canadian Computing Competition");
hash.Add("CUZ", "because");
hash.Add("TY", "thank-you");
hash.Add("YW", "you’re welcome");
hash.Add("TTYL", "talk to you later");

string input = "";
do{
    input = sr.ReadLine();
    if(hash.ContainsKey(input)){
        Console.WriteLine(hash[input]);
    }else{
        Console.WriteLine(input);
    }
}while(input != "TTYL");



// github용 파일 복사
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Code Num > ");
Console.ForegroundColor = ConsoleColor.White;
Filecopy fc = new Filecopy(int.Parse(sr.ReadLine()));
try{
    File.Copy(fc.getThisPath(), fc.getTargetPath(), true);
}catch(Exception e){
    Console.WriteLine(e.ToString());
}finally{
    Console.WriteLine("save done");
}

