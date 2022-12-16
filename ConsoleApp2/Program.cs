using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{ 
    public abstract class parent 
    {
        int a = 3;
        int b = 3;
        public int A { get { return a; } set { a = value; } }
        public int B { get { return b; } set { b = value; } }
        public abstract int add();
    }

    class show : parent
    { 
        public show()
        {
            A = B;
        }
        public show(int a, int b)
        {
            A = a; 
            B = b;  
        } 
        public override int add()
        {
            return A + B;
        } 
        public int sub()
        {
            return A - B;
        }
    }
    internal class Program  
    { 
        static void Main(string[] args)
        {
            show test = new show(3, 4);
            Console.WriteLine(test.add());
            test = new show(6, 7);
            Console.WriteLine(test.add());
            Console.WriteLine(test.sub());
        } 
    }
}
