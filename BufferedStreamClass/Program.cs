using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BufferedStreamClass
{
    class Program
    {
        static void Main(string[] args)
        {
          FileStream fileStream =File.Create(@"F:\text21.txt");
            BufferedStream bs = new BufferedStream(fileStream, 100);
            for (int i= 0; i <100; i++)
            {
                string s = "This is line " + i + "\n";
                byte[] bytes = Encoding.UTF8.GetBytes(s);
                bs.Write(bytes, 0, bytes.Length);
            }
            bs.Flush();
        }
    }
}
