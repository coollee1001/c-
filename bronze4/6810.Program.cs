//https://www.acmicpc.net/problem/6810

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int sum = 91;
for(int i=1; i<=3; i++){
    if(i%2 == 0){
        sum += int.Parse(sr.ReadLine()) * 3;
    }else{
        sum += int.Parse(sr.ReadLine());
    }
}
Console.WriteLine("The 1-3-sum is {0}", sum);

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

