// https://www.acmicpc.net/problem/28235

using System.Collections;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

// 각 데이터
Hashtable ht = new Hashtable();
ht.Add("SONGDO", "HIGHSCHOOL");
ht.Add("CODE", "MASTER");
ht.Add("2023", "0611");
ht.Add("ALGORITHM", "CONTEST");

// 데이터 입력
var inputData = sr.ReadLine();
sw.WriteLine(ht[inputData]);

sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();