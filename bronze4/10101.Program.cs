//https://www.acmicpc.net/problem/10101

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int[] angleArr = new int[3];
int sum = 0;
for(int i = 0; i<3; i++){
    angleArr[i] = int.Parse(sr.ReadLine());    
    sum += angleArr[i];
}
if(sum == 180){
    if(angleArr[0] != angleArr[1] && angleArr[0] != angleArr[2] && angleArr[1] != angleArr[2]){
        Console.WriteLine("Scalene");
    }else if(angleArr[0] == angleArr[1] && angleArr[0] == angleArr[2] && angleArr[1] == angleArr[2]){
        Console.WriteLine("Equilateral");
    }else{
        Console.WriteLine("Isosceles");
    }
}else{
    Console.WriteLine("Error");
}


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();

