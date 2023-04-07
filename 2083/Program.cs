string temp;
while(!(temp = Console.ReadLine()).Equals("# 0 0")){
    string[] info = temp.Split(" ");
    temp = "Junior";
    if(17 < int.Parse(info[1]) || 80 <= int.Parse(info[2])){
        temp = "Senior";
    }
    Console.WriteLine("{0} {1}", info[0], temp);
}