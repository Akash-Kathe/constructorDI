using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorDI
{
    public class Demo
    {
        private Abc a;
       public Abc A
        {
            get { return a; }
            set { a = value; }
        }
        public void SetGet()
        {
            a.disp();
        }

        //>>>constructor dI
      /*  public Demo(Abc d)
        {
            a = d;
            a.disp();
        }*/


    }
}
