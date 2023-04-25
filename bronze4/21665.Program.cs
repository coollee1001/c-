// https://www.acmicpc.net/problem/21665

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var nm = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
char[,] data = new char[nm[0], nm[1]];
for(int i=0; i<nm[0]; i++){
    var temp = sr.ReadLine().ToCharArray();
    for(int j=0; j<nm[1]; j++){
        data[i, j] = temp[j];
    }
}
sr.ReadLine();
char[,] data2 = new char[nm[0], nm[1]];
for(int i=0; i<nm[0]; i++){
    var temp = sr.ReadLine().ToCharArray();
    for(int j=0; j<nm[1]; j++){
        data2[i, j] = temp[j];
    }
}
int count = 0;
for(int i=0; i<nm[0]; i++){
    for(int j=0; j<nm[1]; j++){
        if(data[i, j] == data2[i, j]){
            count++;
        }
    }
}

Console.WriteLine(count);

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();


