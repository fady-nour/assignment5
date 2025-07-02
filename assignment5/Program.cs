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
        public static void SumSub(int a,int b,out int sum ,out int sub)
            {
            sum = a + b ;
            sub = a - b ;

            }
        public static int Sumdigit(string n)
        {
            int sum = 0;
            int y = n.Length;
            int a = Convert.ToInt32(n);
            int r;
            for (int i = 0; i < y; i++)
            {
               r=a % 10;
                sum += r;
                a /= 10;
   
            }
           
            return sum;
        }
        public static bool IsPrime(int n)
        {
            if (n <=1)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static void MinMaxArray(ref int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];

                }

            }
        }
        public static int FactOfNum(int a)
        {
            int Fact = 1;
            for (int i = 2; i <= a; i++)
            {
                Fact = Fact * i;
            }
            return Fact;
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
            #region Q3 result of summation and subtracting of two numbers
            //Console.WriteLine("enter num 1");
            // int x=int.Parse(Console.ReadLine());
            //Console.WriteLine("enter num 1");
            // int y=int.Parse(Console.ReadLine());
            //SumSub(x, y, out int sum, out int sub);
            //Console.WriteLine("Sum = " + sum);
            //Console.WriteLine("Sub = " + sub);
            #endregion
            #region Q4 the individual digits of a given number.
            //string x = "25";
            //Console.WriteLine(Sumdigit(x));
            #endregion
            #region Q5 Ispeime
            //int a =int.Parse(Console.ReadLine());
            //if (IsPrime(a))
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
            #endregion
            #region Q6 MinMaxArray, to return the minimum and maximum values stored in an array
            //int[] arr = { 5, 6, 7, 8, 4, 9, 10 };
            //MinMaxArray(ref arr, out int max, out int min);
            //Console.WriteLine($"max = {max}");
            //Console.WriteLine($"min = {min}");
            #endregion
            #region Q7 factorial
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine(FactOfNum(a));
            #endregion
        }
    }
}
