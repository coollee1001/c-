//https://www.acmicpc.net/problem/6764

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int[] flag = new int[4];
int sum = 0;
for(int i=0; i<flag.Length; i++){
    flag[i] = int.Parse(sr.ReadLine());
}

for(int i=0; i<flag.Length-1; i++){
    if(flag[i] < flag[i+1]){
        sum += 2;
    }else if(flag[i] > flag[i+1]){
        sum += -1;
    }
}

if(sum == 6){
    Console.WriteLine("Fish Rising");
}else if(sum == -3){
    Console.WriteLine("Fish Diving");
}else if(sum == 0){
    Console.WriteLine("Fish At Constant Depth");
}else{
    Console.WriteLine("No Fish");
}


// github용 파일 복사
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Code Num > ");
Console.ForegroundColor = ConsoleColor.White;
Filecopy fc = new Filecopy(int.Parse(sr.ReadLine()));
try{
    File.Copy(fc.getThisPath(), fc.getTargetPath(), true);
}catch(Exception e){
    Console.WriteLine(e.ToString());
}finally{
    Console.WriteLine("save done");
}

