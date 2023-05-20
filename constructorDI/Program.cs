namespace constructorDI
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Constructor DI");
          
            Demo d = new Demo(new A());
            d = new Demo(new B());
            d = new Demo(new C());
*/ 
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("setter getter DI");
            Demo D1 = new Demo();
            Demo D2 = new Demo();
            Demo D3 = new Demo();
            D1.A = new A();
            D2.A = new B();
            D3.A = new C();

            D1.SetGet();
            D2.SetGet();
            D3.SetGet();
           // Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>");
           // Console.WriteLine(" interface  DI");
        }
    }
}