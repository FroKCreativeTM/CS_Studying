using System;
using System.IO;
using System.Text;

namespace BinaryWriter_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream();

            BinaryWriter bw = new BinaryWriter(ms);
            bw.Write("Hello world!" + Environment.NewLine);
            bw.Write("Todd Howard!" + Environment.NewLine);
            bw.Write(32000);
            bw.Flush();

            ms.Position = 0;
            BinaryReader br = new BinaryReader(ms);
            string first = br.ReadString();
            string second = br.ReadString();
            int result = br.ReadInt32();

            Console.Write("{0}{1}{2}", first, second, result);
        }
    }
}
