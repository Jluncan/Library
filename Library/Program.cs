using MyLibrary;

namespace Library {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine(Class1.About);

            var c1 = new Class1();
            Console.WriteLine(c1.About2);

        }
    }
}
