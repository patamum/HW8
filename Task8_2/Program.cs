namespace Task8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\SJ\Test\Numbers.txt";
            Random random = new Random();
            using(StreamWriter sw = new StreamWriter(path, false))
            {
                for(int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-20, 20));
                }
            }
            int s = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++) 
                {
                    int num = Convert.ToInt32(sr.ReadLine());
                    s += num;
                }
            }
            Console.WriteLine("Сумма чисел в файле {0}:", s);
        }
    }
}