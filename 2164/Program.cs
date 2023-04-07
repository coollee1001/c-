using System;

namespace VS_CODE{
    class Program{
        static void Main(string[] args){
            string temp;
            string[] aeiou = {"a", "e", "i", "o", "u"};
            while(!(temp = Console.ReadLine()).Equals("#")){
                int count = 0;
                for(int i=0; i<temp.Length; i++){
                    for(int j=0; j<aeiou.Length; j++){
                        if(temp.Substring(i, 1).ToLower().Equals(aeiou[j])) count++;
                    }
                }
                Console.WriteLine(count);
            }

        }
    }
}