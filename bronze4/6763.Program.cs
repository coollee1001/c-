//https://www.acmicpc.net/problem/6763

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int over = 0, fine = 0;
for(int i=0; i<2; i++){
    if(i == 1){
        over += int.Parse(sr.ReadLine());
    }else{
        over -= int.Parse(sr.ReadLine());
    }
}
if(1 <= over && over <= 20){
    fine = 100;
}else if(21 <= over && over <= 30){
    fine = 270;
}else if(31<=over){
    fine = 500;
}else{
    Console.WriteLine("Congratulations, you are within the speed limit!");
    return;
}
Console.WriteLine("You are speeding and your fine is ${0}.", fine);

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
