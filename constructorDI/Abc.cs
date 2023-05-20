using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorDI
{
    public interface Abc
    {
        void disp();
    }
   public class A : Abc
    {
        public void disp()
        {
            Console.WriteLine("A");
        }
    }
    public class B : Abc
    {
        public void disp()
        {
            Console.WriteLine("B");
        }
    }
    public class C : Abc
    {
        public void disp()
        {
            Console.WriteLine("C");
        }
    }
}
