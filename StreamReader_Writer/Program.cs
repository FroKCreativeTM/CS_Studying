using System;
using System.IO;
using System.Text;

namespace StreamReader_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream();

            StreamWriter sw = new StreamWriter(ms, Encoding.UTF8);
            sw.WriteLine("Hello world!");
            sw.WriteLine("Todd howard");
            sw.Write(32000);
            sw.Flush();

            // 잊으면 안 된다!
            ms.Position = 0;

            StreamReader sr = new StreamReader(ms, Encoding.UTF8);
            string text = sr.ReadToEnd();
            Console.WriteLine(text);
        }
    }
}
