using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
        }

        public string Prefix(string input){
            int length = input.Length;
            int words = 1;
            string output;

            if(input == null){
                return null;
            }

            foreach(char c in input){
                if(c ==' '){
                    words++;
                }
            }

            if(length > 0){
                output = string.Format("{1},{2}:{3}",length,words,input);
            }else{
                words--;
                output = string.Format("{1},{2}:{3}",length,words,input);
            }

            return output;
        }
    }
}
