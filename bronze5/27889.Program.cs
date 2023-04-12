//https://www.acmicpc.net/problem/27889

using System.Collections;

StreamReader sr = new StreamReader(Console.OpenStandardInput());

Hashtable ht = new Hashtable();
ht.Add("NLCS", "North London Collegiate School");
ht.Add("BHA", "Branksome Hall Asia");
ht.Add("KIS", "Korea International School");
ht.Add("SJA", "St. Johnsbury Academy");

Console.WriteLine(ht[sr.ReadLine()]);


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

