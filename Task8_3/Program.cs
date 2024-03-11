namespace Task8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //в файле
            //Люблю грозу в начале мая,
            //Когда весенний первый гром,
            //Как бы резвяся и играя
            //Грохочет в небе голубом.

            string path = @"C:\SJ\Test\MyText.txt";
            int charCount = File.ReadAllText(path).Length;
            int strCount = File.ReadAllLines(path).Length;
            string[] txtArray;
            string str = "";
            char[] delimChar = { ' ', '\r', '\n' };
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    str += sr.ReadLine() + ' ';
                    
                }               
                txtArray = str.Split(delimChar);
            }

            Console.WriteLine("Количество символов в файле {0}", charCount); //+ перевод каретки и пробелы
            Console.WriteLine("Количество строк в файле {0}", strCount);
            Console.WriteLine("Количество слов в файле {0}", txtArray.Length - 1);
        }
    }
}