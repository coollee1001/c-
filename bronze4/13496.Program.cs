//https://www.acmicpc.net/problem/13496

StreamReader sr = new StreamReader(Console.OpenStandardInput());

var n = int.Parse(sr.ReadLine());
for(int i=0; i<n; i++){
    var inputInfo = sr.ReadLine().Split();
    int[] temp = new int[3];
    for(int j=0; j<temp.Length; j++){
        temp[j] = int.Parse(inputInfo[j]);
    }
    int sum = 0;
    while(temp[0]-- != 0){
        var inputData = sr.ReadLine().Split();
        int[] temp2 = new int[2];
        for(int j=0; j<temp2.Length; j++){
            temp2[j] = int.Parse(inputData[j]);
        }
        if(Math.Ceiling((double)temp2[0]/temp[1]) <= temp[2]) sum+= temp2[1];
    }
    Console.WriteLine("Data Set {0}:", i+1);
    Console.WriteLine(sum);
    if(i+1!=n) Console.WriteLine();
}

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();