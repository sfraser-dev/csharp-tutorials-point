// Tutorials Point C# PDF (http://www.tutorialspoint.com/csharp/)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rectangle1
{
    class Rectangle
    {
        double length, width;
        public void acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double getarea()
        {
            return length * width;
        }
        public void display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", getarea());
        }
        public void readinfo()
        {
            Console.Write("input length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("input length: ");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public int factorial(int num) // a recursive function
        {
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }
        public void swap(int x, int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        public void swapByRef(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        public void swapByOutput(int x, int y, out int o1, out int o2, out int o3)
        {
            o1 = x;
            o2 = y;
            o3 = x + y;
        }
        public int addElements(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
                Console.Write("{0} ", i);
            }
            return sum;
        }
    }

    class Program
    {
        enum Days { Sun = 0, Mon, Tues, Wed, Thur, Fri, Sat };

        static void Main(string[] args)
        {
            // Instansiate a Rectangle
            Console.WriteLine("Rectangle class:");
            Rectangle rect = new Rectangle();
            rect.readinfo();
            rect.display();

            // A recursive function
            Console.WriteLine("\nRecursive function:");
            Console.WriteLine("factorial 4: = {0}", rect.factorial(4));

            // A swap function (swap by reference and swap by output)
            Console.WriteLine("\nSwapping:");
            int a = 100;
            int b = 200;
            Console.WriteLine("Original values: a={0}, b={1}", a, b);
            rect.swap(a, b);
            Console.WriteLine("Swap (copy args): a={0}, b={1}", a, b);
            rect.swapByRef(ref a, ref b);
            Console.WriteLine("Swap (by reference): a={0}, b={1}", a, b);
            int summation;
            rect.swapByOutput(a, b, out b, out a, out summation);
            Console.WriteLine("Swap (by output): a={0}, b={1}, summation={2}", a, b, summation);

            // 1D Arrays
            Console.WriteLine("\nArrays:");
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = i + 100;
            }
            int elementCount = 0;
            foreach (int i in arr)
            {
                Console.WriteLine("arr [{0}] = {1}", elementCount++, i);
            }
            // 2D Arrays
            int[][] arr2d = new int[5][];
            for (int i = 0; i < arr2d.Length; i++)
            {
                arr2d[i] = new int[4];
            }
            elementCount = 1;
            for (int r = 0; r < arr2d.Length; r++)
            {
                for (int c = 0; c < arr2d[r].Length; c++)
                {
                    arr2d[r][c] = elementCount * elementCount;
                    elementCount++;
                    Console.Write("{0, 5} ", arr2d[r][c]); // String.Format
                }
                Console.Write("\n");
            }
            // Param arrays
            int[] weeArr = { 1, 2, 3 };
            int[] bigArr = new int[] { 1, 2, 3, 2, 1, 100 };
            Console.WriteLine("(sum = {0})", rect.addElements(weeArr));
            Console.WriteLine("(sum = {0})", rect.addElements(bigArr));

            // Strings
            Console.WriteLine("\nStrings:");
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";
            string fullname = fname + lname;
            Console.WriteLine("Full name: {0}", fullname);
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);
            DateTime bod = new DateTime(1976, 3, 25, 16, 14, 04);
            string chat = String.Format("Message sent at {0:t} on {0:D}", bod);
            Console.WriteLine("Message: {0}", chat);
            string str1 = "this is test";
            string str2 = "this is text";
            string strResult = null;
            strResult = (String.Compare(str1, str2) == 0) ? "str1 and str2 are equal" : "str1 and str2 are different";
            Console.WriteLine(strResult);
            strResult = (str1.Contains("test")) ? "str1 contains test" : "str1 does not contain test";
            Console.WriteLine(strResult);
            string[] strConcat = new string[] { str1, str2 };
            strResult = String.Join("\n", strConcat);
            Console.WriteLine(strResult);

            // Enums
            Console.WriteLine("\nEnums:");
            Console.WriteLine("Mon={0}", (int)Days.Mon);
            Console.WriteLine("Fri={0}", (int)Days.Fri);

            Console.WriteLine("\n\n... hit any key to exit");
            Console.ReadKey();
        }   // Main function
    }

}
