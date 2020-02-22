using System;

namespace Problems
{
  public class Program
    {
        static void Main(string[] args)
        {
            string x ="";
            Console.WriteLine(Prefix(x));
        }
        public static string Prefix(string input)
        {
            if(input.Length==0)
            {
                string ans = "0:0";
                return ans;
            }
            int len = input.Length;
            string[] words = input.Split(' ');
            int numwords = words.Length;
            string final = $"{len},{numwords}:{input}";
            return final;
        }
    }
}
