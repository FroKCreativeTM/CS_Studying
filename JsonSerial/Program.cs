using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;

namespace JsonSerial
{
    [Serializable]
    class Person
    {
        public int age;
        public string name;

        public Person(int _age, string _name)
        {
            this.age = _age;
            this.name = _name;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.age, this.name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DataContractJsonSerializer json 
                = new DataContractJsonSerializer(typeof(Person));

            MemoryStream ms = new MemoryStream();

            Person person = new Person(49, "Todd howard");

            json.WriteObject(ms, person);

            ms.Position = 0;

            Person clone = json.ReadObject(ms) as Person;

            Console.WriteLine(clone);

            byte[] buf = ms.ToArray();
            Console.WriteLine(Encoding.UTF8.GetString(buf));
        }
    }
}
