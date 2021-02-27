using System;
using System.IO;

namespace memorystream
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] shortBytes = BitConverter.GetBytes((short)32000);
            byte[] intBytes = BitConverter.GetBytes(1652300);

            MemoryStream ms = new MemoryStream();
            ms.Write(shortBytes, 0, shortBytes.Length);
            ms.Write(intBytes, 0, intBytes.Length);

            // ms.Position = 0;

            // 메모리 스트림으로 부터 역직렬화
            //byte[] outBytes = new byte[2];
            //ms.Read(outBytes, 0, 2);
            //int shortResult = BitConverter.ToInt16(outBytes, 0);
            //Console.WriteLine(shortResult);

            //outBytes = new byte[4];
            //ms.Read(outBytes, 0, 4);
            //int intResult = BitConverter.ToInt32(outBytes, 0);
            //Console.WriteLine(intResult);

            byte[] buf = ms.ToArray();

            int shortResult = BitConverter.ToInt16(buf, 0);
            Console.WriteLine(shortResult);
            int intResult = BitConverter.ToInt32(buf, 2);
            Console.WriteLine(intResult);





        }
    }
}
