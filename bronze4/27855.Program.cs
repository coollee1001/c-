// https://www.acmicpc.net/problem/27855

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var one = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
var two = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);

int[] score = new int[2];
score[0] = 3 * one[0] + one[1];
score[1] = 3 * two[0] + two[1];

string result = "NO SCORE";
if(score[0] > score[1]) result = "1" + " " + (score[0] - score[1]);
else if(score[0] < score[1]) result = "2" + " " + (score[1] - score[0]);
sw.WriteLine(result);
sw.Close();


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
