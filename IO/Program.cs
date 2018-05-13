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

            var person3 = new LazyAth2<Person>();
            Console.WriteLine(person3.GetValue().Age);
            Console.WriteLine(person3.GetValue().Age);
            foreach (var item in AthFibonaci.Fibonaci().Take(10)) {
                Console.WriteLine(item);
            }
            AthApi.GetUsers();
            Console.WriteLine("o");
            //foreach (var item in AthApi.GetUsers()) {
            //    Console.WriteLine(item.Name);
            //    //foreach (var post in item.Posts) {
            //    //    //Console.WriteLine(post.Title);
            //    //}
            //}

        }
    }
}
