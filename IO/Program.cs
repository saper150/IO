using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO {


    class Person {
        public int Age { get; set; }
        public Person(int age) {
            Age = age;
        }
        public Person() {

        }
    }

    class Program {

        static void Main(string[] args) {
            var person1 = new Lazy<Person>(()=>new Person(1));
            var person2 = new Lazy<Person>();

            foreach (var item in AthFibonaci.Fibonaci().Take(10)) {
                Console.WriteLine(item);
            }
        }
    }
}
