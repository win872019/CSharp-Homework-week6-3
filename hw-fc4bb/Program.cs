namespace hw_fc4bb
{
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            string SourcePath = @"C:\temp\fc4bb.csv";
            string ResultPath = @"C:\temp\fc4bb-web-0924.html";

            string[] fc4bb = File.ReadAllLines(SourcePath, Encoding.UTF8);

            foreach (string line in fc4bb)
            {
                Console.WriteLine(line);
            }


            for (int i = 0; i < fc4bb.Length; i++)
            {
                if (i == 0)
                {
                    fc4bb[i] = fc4bb[i].Insert(fc4bb[i].Length, "</th>\n</tr>").Insert(0, "<table>\n<tr>\n<th>").Replace(",", "</th>\n<th>");
                }
                else
                {
                    fc4bb[i] = fc4bb[i].Insert(fc4bb[i].Length, "</td>\n</tr>").Insert(0, "<tr>\n<td>").Replace(",", "</td>\n<td>");
                    if (i == fc4bb.Length - 1)
                    {
                        fc4bb[i] = fc4bb[i].Insert(fc4bb[i].Length, "\n</table>");
                    }

                }
            }


            foreach (string line in fc4bb)
            {
                Console.WriteLine(line);
            }


            File.WriteAllLines(ResultPath, fc4bb, Encoding.UTF8);


            Console.ReadKey();
        }
    }
}