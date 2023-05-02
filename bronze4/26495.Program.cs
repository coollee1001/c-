// https://www.acmicpc.net/problem/26495

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var n = sr.ReadLine().ToCharArray();
string[] num = new string[10];
num[0] = "0000\n0  0\n0  0\n0  0\n0000";
num[1] = "   1\n   1\n   1\n   1\n   1";
num[2] = "2222\n   2\n2222\n2\n2222";
num[3] = "3333\n   3\n3333\n   3\n3333";
num[4] = "4  4\n4  4\n4444\n   4\n   4";
num[5] = "5555\n5\n5555\n   5\n5555";
num[6] = "6666\n6\n6666\n6  6\n6666";
num[7] = "7777\n   7\n   7\n   7\n   7";
num[8] = "8888\n8  8\n8888\n8  8\n8888";
num[9] = "9999\n9  9\n9999\n   9\n   9";
for(int i=0; i<n.Length; i++){
    Console.WriteLine(num[n[i]-'0']);
    Console.WriteLine();
}

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
