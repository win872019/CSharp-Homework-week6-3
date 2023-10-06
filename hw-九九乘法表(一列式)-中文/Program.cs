namespace hw_九九乘法表_中文
{
    using System;
    using System.IO;
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\hw-九九乘法表-中文.txt";

            ////新增.txt檔 & 寫入
            string[] li = new string[90];
            int count = 0;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    li[count] = $"{i}*{j}={i * j}";
                    count++;

                }
                li[count] = "";
                count++;
            }


            //foreach (string a in li)
            //{
            //    Console.WriteLine(a);
            //}

            File.WriteAllLines(path, li);

            string[] readText = File.ReadAllLines(path);


            foreach (string line in readText)
            {
                Console.WriteLine(line);
            }


            for(int i=0; i<readText.Length;i++)
            {
                readText[i]= readText[i].Replace("0", "零").Replace("1", "壹")
                .Replace("2", "貳").Replace("3", "參").Replace("4", "肆").Replace("5", "伍")
                .Replace("6", "陸").Replace("7", "柒").Replace("8", "捌").Replace("9", "玖");
            }


            //string readText2 = readText.Replace("0", "零").Replace("1", "壹")
            //    .Replace("2", "貳").Replace("3", "參").Replace("4", "肆").Replace("5", "伍")
            //    .Replace("6", "陸").Replace("7", "柒").Replace("8", "捌").Replace("9", "玖");

            File.WriteAllLines(path, readText, Encoding.UTF8);

            Console.ReadKey();



          
            //string path = @"C:\temp\指定文字檔-2-九九乘法表.txt";
            //string path2 = @"C:\temp\hw-九九乘法表-中文.txt";

            //// 讀取            
            //string[] readText = File.ReadAllLines(path);

            //foreach (var item in readText)
            //{
            //    Console.WriteLine(item);
            //}

            //int i = 0;
            //while (i < readText.Length)
            //{
            //    readText[i] = readText[i].Replace("0", "零").Replace("1", "壹")
            //    .Replace("2", "貳").Replace("3", "參").Replace("4", "肆").Replace("5", "伍")
            //    .Replace("6", "陸").Replace("7", "柒").Replace("8", "捌").Replace("9", "玖");
            //    i++;
            //}

            //foreach (var item in readText)
            //{
            //    Console.WriteLine(item);
            //}

            //File.WriteAllLines(path2, readText, Encoding.UTF8);

            //Console.ReadKey();

            



        }
    }
}