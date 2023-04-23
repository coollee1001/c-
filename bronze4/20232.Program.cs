// https://www.acmicpc.net/problem/20232

using System.Collections;

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var str = "1995: ITMO\n1996: SPbSU\n1997: SPbSU\n1998: ITMO\n1999: ITMO\n2000: SPbSU\n2001: ITMO\n2002: ITMO\n2003: ITMO\n2004: ITMO\n2005: ITMO\n2006: PetrSU, ITMO\n"
+ "2007: SPbSU\n2008: SPbSU\n2009: ITMO\n2010: ITMO\n2011: ITMO\n2012: ITMO\n2013: SPbSU\n2014: ITMO\n2015: ITMO\n2016: ITMO\n2017: ITMO\n2018: SPbSU\n2019: ITMO";
Hashtable ht = new Hashtable();
var strArr = str.Split("\n");
for(int i=0; i<strArr.Length; i++){
    var data = strArr[i].Split(":");
    ht.Add(data[0], data[1].ToString().Trim());
}
Console.WriteLine(ht[sr.ReadLine()]);



// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


