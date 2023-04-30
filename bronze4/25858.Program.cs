// https://www.acmicpc.net/problem/25858

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var data = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
int sum = 0, index = 0;
int[] people = new int[data[0]];
while(data[0]-- != 0){
    people[index] = int.Parse(sr.ReadLine());
    sum += people[index++];
}
data[1]/=sum;
for(int i=0; i<people.Length; i++){
    Console.WriteLine(data[1]*people[i]);
}

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();