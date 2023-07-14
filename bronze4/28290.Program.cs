// https://www.acmicpc.net/problem/28290

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var str = sr.ReadLine();

if(str.CompareTo("fdsajkl;") == 0 || str.CompareTo("jkl;fdsa") == 0) sw.WriteLine("in-out");
else if(str.CompareTo("asdf;lkj") == 0 || str.CompareTo(";lkjasdf") == 0) sw.WriteLine("out-in");
else if(str.CompareTo("asdfjkl;") == 0) sw.WriteLine("stairs");
else if(str.CompareTo(";lkjfdsa") == 0) sw.WriteLine("reverse");
else sw.WriteLine("molu");

sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();