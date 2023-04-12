//https://www.acmicpc.net/problem/6825

StreamReader sr = new StreamReader(Console.OpenStandardInput());
float weight = float.Parse(sr.ReadLine());
float height = float.Parse(sr.ReadLine());
float bmi = weight/(height * height);

if(bmi < 18.5){
    Console.WriteLine("Underweight");
}else if(bmi <= 25){
    Console.WriteLine("Normal weight");
}else{
    Console.WriteLine("Overweight");
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

