//https://www.acmicpc.net/problem/5928

StreamReader sr = new StreamReader(Console.OpenStandardInput());

string[] inputDate = sr.ReadLine().Split(" ");
int[] inputDateParseInt = new int[3];
int sum = 0, tempsum = 0;
for(int i=0; i<inputDateParseInt.Length; i++){
    inputDateParseInt[i] = int.Parse(inputDate[i]);
}
sum += inputDateParseInt[0] * 24 * 60;
sum += inputDateParseInt[1] * 60;
sum += inputDateParseInt[2];

tempsum += 11 * 24 * 60;
tempsum += 11 * 60;
tempsum += 11;

if(sum < tempsum) Console.WriteLine(-1);
else Console.WriteLine(sum - tempsum);

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
