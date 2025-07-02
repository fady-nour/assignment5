namespace assignment5
{
    internal class Program
    {
        public static void Swap(ref int a ,ref int b)
        {
            Console.WriteLine("number inside method");
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);
            int temp = a;
            a= b;
            b= temp;
            Console.WriteLine("number inside method after swap");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

        }
        public static void Swap2( int a,  int b)
        {
            Console.WriteLine("number inside method");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("number inside method after swap");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

        }
        static void Main(string[] args)
        {
            #region Q1 value type refrence value  type value
            //int x = 5, y = 10;
            
            //Swap(ref x, ref y);
            //Console.WriteLine("number after passing");
            //Console.WriteLine("x = " + x);
            //Console.WriteLine("y = " + y);

            //int c = 5, u = 10;
            //Swap2( c, u);
            //Console.WriteLine("number after passing");
            //Console.WriteLine("c = " + c);
            //Console.WriteLine("u = " + u);
            #endregion

        }
    }
}
