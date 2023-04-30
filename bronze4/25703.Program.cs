// https://www.acmicpc.net/problem/25703

StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
int count = 1;
string str = "a";
Console.WriteLine("int {0};", str);
while(n-- != 0){
    Console.Write("int ");
    for(int i=0; i<count; i++){
        Console.Write("*");
    }
    Console.WriteLine("ptr{0} = &{1};", count==1?"":count ,str);
    str = "ptr"+(count==1?"":count);
    count++;
}


// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();