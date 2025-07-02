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
        public static int SumArr(int[] arr)
        {
            int sum = 0;
             arr = new int[] { 8, 6, 2, 1, 4, 7 }; arr[2] = 500;
            foreach(int i in arr)
            {
                sum += i;
            
            }
            return sum;
        }
        public static int SumArr2(ref int[] arr)
        {
            int sum = 0;
            arr = new int[] { 8, 6, 2, 1, 4, 7 }; arr[2] = 500;
            foreach (int i in arr)
            {
                sum += i;

            }
            return sum;
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
            #region Q2 refrence type by value and by refrence
            //int[] num = { 5, 6, 8, 7, 4, 1 };
            //Console.WriteLine("before passing = " + num[2]);
            //SumArr(num);
            //Console.WriteLine("after passing = " + num[2]);

            //Console.WriteLine("before passing = " + num[2]);
            //SumArr2(ref num);
            //Console.WriteLine("after passing = " + num[2]);
            #endregion

        }
    }
}
