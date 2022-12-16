using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class parent
    {
        int a;
        int b;
        public int A { get { return a; } set { a = value; } }
        public int B { get { return b; } set { b = value; } }
        public abstract int add();
    }

    class show : parent
    {
        public override int add()
        {
            return this.a + 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
