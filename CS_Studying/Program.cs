using System;

namespace CS_Studying
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] boolBytes = BitConverter.GetBytes(true);
            byte[] shortBytes = BitConverter.GetBytes((short)32000);
            byte[] intBytes = BitConverter.GetBytes(1652300);

            Console.WriteLine(BitConverter.ToString(boolBytes));
            Console.WriteLine(BitConverter.ToString(shortBytes));
            Console.WriteLine(BitConverter.ToString(intBytes));

            bool boolResult = BitConverter.ToBoolean(boolBytes, 0);
            short shortResult = BitConverter.ToInt16(shortBytes, 0);
            int intResult = BitConverter.ToInt32(intBytes, 0);

            Console.WriteLine(boolResult);
            Console.WriteLine(shortResult);
            Console.WriteLine(intResult);

            byte[] buf = new byte[4];
            buf[0] = 0x4c;
            buf[1] = 0x36;
            buf[2] = 0x19;
            buf[3] = 0x00;

            int result = BitConverter.ToInt32(buf);
            Console.WriteLine(result);

            int n = 1652300;
            string text = n.ToString();

            int result2 = int.Parse(text);
        }
    }
}
