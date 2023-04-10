//https://www.acmicpc.net/problem/5532

using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();    
sw.AutoFlush = true;

int n = 5, vacationDay = 0;
int[] labcd = new int[n];
for(int i=0; i<n; i++){
    labcd[i] = int.Parse(sr.ReadLine());
}

// 걸리는 일수 계산
int kor = labcd[1]/labcd[3];
int math = labcd[2]/labcd[4];

// 남는 일자 반올림
if(labcd[1] % labcd[3] != 0){
    kor++;
}
if(labcd[2] % labcd[4] != 0){
    math++;
}

// 방학일수에서 제일 많이 걸리는 과목을 빼주기
vacationDay = (labcd[0] - (kor > math ? kor : math));

sw.WriteLine(vacationDay);

// github용 파일 복사
Filecopy fc = new Filecopy(5532);
File.Copy(fc.getThisPath(), fc.getTargetPath());