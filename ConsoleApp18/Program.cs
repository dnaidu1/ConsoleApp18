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

            // The basic concepts about loops, variables, calling methods, counters have been refreshed. Working functionally for over 2.5 years, this is at the same time difficult for me. This program is going to be enriching 

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {

                int a = x; //declaring integer a and assigning value of x
                int b = y;  //declaring integer b and assigning value of y
                int i, j, k; //declaring integers i, j and k
                for (i = a; i < b; i++) //for loop inserted from a to b
                {
                    k = 0; //initializing k with value 0
                    if (i > 1) //if statement to check for values more than 1
                    {
                        for (j = 2; j < i; j++) //for loop to check for prime numbers 
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
                int i, total = 0; //declaring integers i and total and assigning value of total as 0
                int result = 1; //declaring integer result and assigning value as 1
                for (i = 1; i <= n1; i++)  //initializing for loop to check for numbers from 1 to 5
                {
                    total = total + result;  //This gives the next number in the series
                    result = (result) + 1;  //result is 1+2+3+4+5 = 15
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
                        rem = n % 10; //remainder of the division 
                        decval = (decval + rem) * binval; //decimal is the sum of decimal value and remainder multiplied by the binary value
                        n = n/10;
                        binval = binval * 2; //final binary value is the product of binary value multiplied by 2
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
        int space, a; //declaring integers space and a
        for (int i = 1; i <= n; i++) //for loop used to calculate the number of rows
        {
            for (space = 1; space <= (n - i); space++) //calculating the number of spaces between stars 
                Console.Write(" "); 
            for (a = 1; a <= i; a++)   
                Console.Write('*'); 
            for (a = (i - 1); a >= 1; a--)    //calculating the number of stars in each row
                Console.Write("*");   //input "*" for the system to identify instead of integer values
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
                int n = b.Length; //delcaring integer n and storing the length of the array
                Boolean[] counted = new Boolean[n];  //A new array called Boolean is created for 1 and 0 
                for (int i = 0; i < n; i++) //for loop created for the number of values 
                {
                    if (counted[i] == true)  //the ith value of array counted is checked and if value is same then the loop continues
                        continue;   
                    int r = 1;  //declaring integer value r and assigning value as 1
                    for (int j = i + 1; j < n; j++)  //for loop created to check for each value's length
                    {
                        if (b[i] == b[j])
                        {
                            counted[j] = true;
                            r++;
                        }

                    }
                    Console.WriteLine(b[i] + " - " + r);  //"-" used to seperate values from their respective lengths 
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}

