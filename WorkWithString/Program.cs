using System.Text.RegularExpressions;

namespace WorkWithString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "        Предложение один  Теперь предложение   два Предложение  три ";
            string str2 = new Regex(@"\A\s+").Replace(str, string.Empty);
            str = str2;
            str2 = new Regex(@"\s+").Replace(str, " ");
            for (int i = 1; i < str2.Length; i++)
            {
                if (Regex.IsMatch(str2[i].ToString(),@"[А-Я]")) 
                {
                    str2 = str2.Insert(i - 1, ".");
                    i++;
                }
            }
            if (Regex.IsMatch(str2, @"\s\z"))
            {
                str2 = str2.Remove(str2.Length - 1);
                str2 += ".";
                Console.WriteLine(str2);
            }
            Console.WriteLine(str2);
            //RegexOptions options = RegexOptions.None;
            //Regex regex = new Regex("[ ]{2,}", options);
            //string res = regex.Replace(str, " ");
            Console.ReadLine();
            //доработать код чтобы текст был корректный
        }
    }
}