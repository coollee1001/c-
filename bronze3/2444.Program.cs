﻿// https://www.acmicpc.net/problem/2444

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
for(int i=1; i<=n; i++){
    for(int j=0; j<n-i; j++){
        sw.Write(" ");
    }
    for(int j=0; j<2*i-1; j++){
        sw.Write("*");
    }
    sw.WriteLine();
}
for(int i=n-1; i>=0; i--){
    for(int j=0; j<n-i; j++){
        sw.Write(" ");
    }
    for(int j=0; j<2*i-1; j++){
        sw.Write("*");
    }
    sw.WriteLine();
}
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
