namespace hw_random
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //p.25
            //var rand=new Random();
            //int num = rand.Next(100);
            //Console.WriteLine(num);
            //Console.ReadKey();



            //p.25~26 - String.Format & 字串格式化 對齊 寫法*

            //var rand = new Random();
            //int[] score = new int[10];
            //string[] student = new string[10];
            //string sheet = String.Format("{0,-15}{1,-15}\n\n","Name","Score");
            //for (int i = 0; i < score.Length; i++)
            //{
            //    student[i] = "Student " + (i + 1);
            //    score[i] = rand.Next(100);
            //    sheet += String.Format("{0,-15}{1,-15}\n", student[i], score[i]);

            //}

            //Console.WriteLine(sheet);
            //Console.ReadKey();


            //p.25~26 - 直接用逗號分開欄位

            // 隨機產生10個亂數 & 產生成績表格
            var rand = new Random();
            int[] score = new int[10];           // 分數
            string[] student = new string[10];   // 學生名字
            string sheet = "";

            for (int i = 0; i < score.Length; i++)
            {
                
                student[i] = "Student" + (i + 1);  // 學生名字: 暫以 Student1, Student2,...Student10 代替
                score[i] = rand.Next(100);         // 隨機產生分數， 放入 分數array
                sheet += $"{student[i]}, {score[i]}\n";  // 名字&分數

            }

            
            string path = @"C:\temp\hw-student_score.txt";

            if(!File.Exists(path))          // 建立 & 寫入 成績表格.txt
            {
                File.WriteAllText(path,sheet);
            }

            
            string readText = File.ReadAllText(path);  // 讀取 成績表格.txt
            Console.WriteLine(readText);   // 印出 成績表格.txt

            Console.ReadKey();










        }
    }
}