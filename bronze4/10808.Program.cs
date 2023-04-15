//https://www.acmicpc.net/problem/10808

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var str = sr.ReadLine().ToCharArray();
var alphabet = new int[26];
for(int i=0; i<str.Length; i++){
    int num = str[i] - 'a';
    alphabet[num] += 1;
}
for(int i=0; i<alphabet.Length; i++){
    Console.Write(alphabet[i]);
    if(i != alphabet.Length-1) Console.Write(" ");
}

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

