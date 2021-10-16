using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        class A
        {

        }
        class B : A
        {
            public object a;
            
        }
        
        class C : B
        {
            public object c;
        }


        static void Main(string[] args)
        {
            A a1 = new A ();
            B b2 = new B();
            B b3 = new B();
            B b4 = new B();
            b2.a = a1;
            b3.a = a1;
            b4.a = b3;
            C c5 = new C();
            c5.a = b2;
            c5.c = b4;
            

        }
    }
}
