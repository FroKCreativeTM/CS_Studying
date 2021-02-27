using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryFormatter_
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
}
