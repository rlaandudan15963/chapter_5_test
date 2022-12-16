using System;
using System.Runtime.Remoting.Messaging;

namespace ConsoleApp1
{
    public interface A//인터페이스는 키워드만 있어도 된다.
    {
        string str_a//프로퍼티는 가능하다
        {
            get;
            set;
        }
        //string str_a; 인터페이스에는 멤버 필드를 사용할 수 없다.
        void Show();
        void Show_each(string a);
    }
    public abstract class B//추상 클래스(public 필요)
    {
        public string str_b;//추상 클래스는 멤버 필드 사용이 가능하다.
        public abstract void Show();
        public abstract void Show_each(string b);
    }
    class Show_A : A
    {
        string str_A;
        //인터페이스에 public이 있어야 인터페이스 멤버를 구현할 수 있다.
        public string str_a
        {
            get
            {
                return str_A;
            }
            set
            {
                str_A = value;
            }
        }
        public Show_A(string a)
        {
            str_a = a;
        }

        public void Show()
        {
            Console.WriteLine(str_a);
        } 
        public void Show_each(string a)
        {
            Console.WriteLine(a);
            string[] str = a.Split(' ');
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        } 
    }
    class Show_B : B
    {
        public Show_B(string str_b)
        {
            this.str_b = str_b;
        }
        
        public override void Show()
        {
            Console.WriteLine(str_b);
        }
        public override void Show_each(string b)
        {
            Console.WriteLine(b);
            string[] str = b.Split(' ');
            for (int i = 0; i < str.Length; i++)
            {
               Console.WriteLine(str[i]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Show_A strA = new Show_A("this is nor a word");
            Show_B strB = new Show_B("this is text word");
            strA.Show();
            strB.Show();
            strA.Show_each("this is what i want");
            strB.Show_each("this is what i show");
        }
    }
}
