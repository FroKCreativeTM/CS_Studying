using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinaryFormatter_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(49, "Todd");

            BinaryFormatter bf =
                new BinaryFormatter();

            // 메모리 스트림에 객체를 직렬화 한다.
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, person);

            ms.Position = 0;

            Person clone = bf.Deserialize(ms) as Person;

            Console.WriteLine(clone);
        }
    }
}
