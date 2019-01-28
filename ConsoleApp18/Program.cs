using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int x = 5, y = 15;
            printPrimeNumbers(x, y);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);
            Console.ReadKey();


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);
            Console.ReadKey();

            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);
            Console.ReadKey();

            int n4 = 5;
            printTriangle(n4);
            Console.ReadKey();

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);
            Console.ReadKey();

            // write your self-reflection here as a comment

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {

                int a = Convert.ToInt32(x);
                int b = Convert.ToInt32(y);
                int i, j, k;
                for (i = a; i < b; i++) 
                {
                    k = 0;
                    if (i > 1) 
                    {
                        for (j = 2; j < i; j++)
                        {
                            if (i % j == 0) 
                            {
                                k = 1; 
                                break; //This is a prime number
                            }
                        }
                        if (k == 0)
                        {
                            Console.WriteLine(i); //if 0, then not a prime number

                        }
                    }
                }
                Console.ReadKey();

            }
            catch
            {
                Console.Write("Exception occured while computing printPrimeNumbers()");
            }
        }
        public static double getSeriesResult(int n1)
        {
            try
            {
                int i, total = 0;
                int result = 1; //value of resukt is 1
                for (i = 1; i <= n1; i++)
                {
                    total = total + result;  //This gives the next number in the series
                    result = (result) + 1;
                }
                return Convert.ToDouble(total);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }

    

        public static long decimalToBinary(long n)
        {
            try
            {
               
                    long s, r2, d;
                    d = n;
                    string mystrng = "";
                    while (n > 0)
                    {
                        r2 = n % 2;
                        mystrng += Convert.ToString(r2);  //convert r2 to string
                        n /= 2; //stay in loop till n is divisible by 2
                    }

                    string dec = "";
                    int Length = mystrng.Length - 1; 
                    while (Length >= 0)
                    {
                        dec = dec + mystrng[Length];
                        Length--;
                    }

                    s = Convert.ToInt64(dec);

                    return s;

                }
                catch
                {
                    Console.WriteLine("Exception occured while computing decimalToBinary()");
                }

                return 0;
            }
            
    

        public static long binaryToDecimal(long n)
        {

            long decval = 0; long binval = 1; long rem;
                try
                {
                    while (n > 0)
                    {
                        rem = n % 10; //
                        decval = (decval + rem) * binval;
                        n = n/10;
                        binval = binval * 2;
                    }
                }
                catch
                {
                    Console.WriteLine("Exception occured while computing binaryToDecimal()");
                }

                return decval;
            }
            

        public static void printTriangle(int n)
        {
            try
            {
        int space, a;
        for (int i = 1; i <= n; i++)
        {
            for (space = 1; space <= (n - i); space++)
                Console.Write(" "); 
            for (a = 1; a <= i; a++)   
                Console.Write('*'); //triangle will be made of *
            for (a = (i - 1); a >= 1; a--)   
                Console.Write("*"); 
            Console.WriteLine();
        }
    }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] b)
        {
            try
            {
                int n = b.Length;
                Boolean[] counted = new Boolean[n]; 
                for (int i = 0; i < n; i++)
                {
                    if (counted[i] == true)
                        continue;   
                    int r = 1;
                    for (int j = i + 1; j < n; j++)  
                    {
                        if (b[i] == b[j])
                        {
                            counted[j] = true;
                            r++;
                        }

                    }
                    Console.WriteLine(b[i] + " - " + r);
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}

