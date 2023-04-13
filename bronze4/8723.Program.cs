//https://www.acmicpc.net/problem/8723

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int[] data = new int[3];
string[] inputdata = sr.ReadLine().Split(" ");
for(int i=0; i<data.Length; i++){
    data[i] = int.Parse(inputdata[i]);
}
Array.Sort(data);
if(Math.Pow(data[0], 2) +  Math.Pow(data[1], 2) == Math.Pow(data[2], 2)){
    Console.WriteLine(1);
}else if(data[0] == data[1] && data[0] == data[2]){
    Console.WriteLine(2);
}else{
    Console.WriteLine(0);
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

