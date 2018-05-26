using System;
using System.Threading;

namespace FactoryExcercise
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private Person(int Id, string Name) {
            this.Name = Name;
            this.Id = Id;
        }

        public class PersonFactory{
            private static int instanceCount;

            public static Person CreatePerson(string name) {
                return new Person(Interlocked.Increment(ref instanceCount), name);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}