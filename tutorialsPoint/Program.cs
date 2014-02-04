// Tutorials Point C# PDF (http://www.tutorialspoint.com/csharp/)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace tutorialsPoint
{
    class MyStaticVariable
    {
        public static int counter = 0;
        public void inc()
        {
            counter++;
        }
        public int returnCount()
        {
            return counter;
        }
    }

    class MyStaticFunction
    {
        public static int counter = 0;
        public static void inc()
        {
            counter++;
        }
        public static int returnCount()
        {
            return counter;
        }
    }

    class TPoint
    {
        double length, width;
        public TPoint()
        {
            Console.WriteLine("TPoint is being constructed");
        }
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
            Console.Write("Input length of rectangle: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input width of rectangle: ");
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

    class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape constructor");
        }
        public Shape(int w, int h)
        {
            width = w;
            height = h;
            Console.WriteLine("Shape constructor, width={0}, height={1}",width,height);
        }
        protected int width;
        protected int height;
        protected double widthPrecise;
        protected double heightPrecise;
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        public void setWidth(double w)
        {
            widthPrecise = w;
        }
        public void setHeight(double h)
        {
            heightPrecise = h;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle()
        {
            Console.WriteLine("Rectangle constructor");
        }
        public Rectangle(int w, int h) : base (w,h)
        {
            Console.WriteLine("Rectangle constructor, width={0}, height={1}",width,height);
        }
        public int getArea()
        {
            return (width * height);
        }
        public double getAreaPrecise()
        {
            return (widthPrecise * heightPrecise);
        }
        public static Rectangle operator +(Rectangle a, Rectangle b)
        {
            Rectangle r = new Rectangle(a.width + b.width, a.height + b.height);
            return r;
        }

    }

    public interface AnimalFarm
    {
        void proclaimComrade();
    }

    abstract class Animal
    {
        public Animal () {
            Console.WriteLine("Animal constructor");
        }
        public abstract void makeNoise();
    }

    class Horse : Animal, AnimalFarm
    {
        public Horse () {
            Console.WriteLine("Horse constructor");
        }
        public override void makeNoise()
        {
            Console.WriteLine("Neigh");
        }
        public void proclaimComrade()
        {
            Console.WriteLine("I will work harder. Napolean is always right");
        }
    }
    class Sheep : Animal, AnimalFarm
    {
        public Sheep () {
            Console.WriteLine("Sheep constructor");
        }
        public override void  makeNoise()
        {
            Console.WriteLine("Baaaaaa");
        }
        public void proclaimComrade() {
            Console.WriteLine("Four legs good. Two legs bad.");
        }
    }

    class Crocodile : Animal
    {
        public Crocodile()
        {
            Console.WriteLine("Crocodile constructor");
        }
        public override void makeNoise()
        {
            Console.WriteLine("Snap snap snap");
        }
    }
    
    class Program
    {
        enum Days { Sun = 0, Mon, Tues, Wed, Thur, Fri, Sat };

        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }

        public void tryDivide(int num1, int num2)
        {
            int result = 0;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result = {0}", result);
            }
        }

        static void Main(string[] args)
        {
            // Instansiate a Rectangle
            Console.WriteLine("Rectangle class:");
            TPoint TP = new TPoint();
            TP.readinfo();
            TP.display();

            // A recursive function
            Console.WriteLine("\nRecursive function:");
            Console.WriteLine("factorial 4: = {0}", TP.factorial(4));

            // A swap function (swap by reference and swap by output)
            Console.WriteLine("\nSwapping:");
            int a = 100;
            int b = 200;
            Console.WriteLine("Original values: a={0}, b={1}", a, b);
            TP.swap(a, b);
            Console.WriteLine("Swap (copy args): a={0}, b={1}", a, b);
            TP.swapByRef(ref a, ref b);
            Console.WriteLine("Swap (by reference): a={0}, b={1}", a, b);
            int summation;
            TP.swapByOutput(a, b, out b, out a, out summation);
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
            Console.WriteLine("(sum = {0})", TP.addElements(weeArr));
            Console.WriteLine("(sum = {0})", TP.addElements(bigArr));

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

            // Static vaiables and functions
            Console.WriteLine("\nStatic:");
            MyStaticVariable c1 = new MyStaticVariable();
            MyStaticVariable c2 = new MyStaticVariable();
            c1.inc();
            c1.inc();
            c1.inc(); // c1.inc() and c2.inc() are both incrementing
            c2.inc(); // the same static variable in class MyStaticVar.
            c2.inc(); // There is only one copy of this static variable
            c2.inc();
            Console.WriteLine("c1 counter={0}", c1.returnCount());
            Console.WriteLine("c2 counter={0}", c2.returnCount());
            // Static functions can access static variable without needing to instantiate an object,
            // the static functions exist even before the object is created.
            Console.WriteLine("c3 counter={0}", MyStaticFunction.returnCount());
            MyStaticFunction.inc();
            MyStaticFunction.inc();
            Console.WriteLine("c3 counter={0}", MyStaticFunction.returnCount());

            // Inheritance
            Console.WriteLine("\nInheritance:");
            Rectangle Rect1 = new Rectangle();
            Rect1.setWidth(2);
            Rect1.setHeight(3);
            Console.WriteLine("Rect1 area = {0}", Rect1.getArea());
            Rectangle Rect2 = new Rectangle(4, 5);
            Console.WriteLine("Rect2 area = {0}", Rect2.getArea());

            // Polymorphism
            Console.WriteLine("\nPolymorphism:");
            Rectangle Rect3 = new Rectangle();
            Rect3.setWidth(0.5);  // Static compile time polymorphism
            Rect3.setHeight(4.8); // Overloading functions setWidth and setHeight
            Console.WriteLine("Rect3 precisie area = {0}", Rect3.getAreaPrecise());
            Rectangle Rect4 = new Rectangle();  // Static compile time polymorphism
            Rect4 = Rect1 + Rect2;              // Operator (+) overloading
            Console.WriteLine("Rect4 area = {0}", Rect4.getArea());
            Sheep Wooly = new Sheep();   // Dynamic overloading (resolved at run-time, not compile-time)
            Wooly.makeNoise();           // Wooly and Boxer are both Animals who override the virtual 
            Horse Boxer = new Horse();   // makeNoise function.
            Boxer.makeNoise();
            Crocodile Charlie = new Crocodile();
            Charlie.makeNoise();

            // Interface
            Console.WriteLine("\nInterface:");
            Wooly.proclaimComrade();  // Implement multiple inheritance (MI) via an interface
            Boxer.proclaimComrade();  // Horses and Sheep are Animals in AnimalFarm
            // Crocodile is an Animal not in AnimalFarm. 
            // C#/.NET isn't keen on MI, hence the interface "kludge".

            // Regular expressions
            Console.WriteLine("\nRegular Expressions:");
            string str = "A Thousand Splendid Suns";
            Console.WriteLine("Matching words that start with 'S': ");
            showMatch(str, @"\bS\S*");
            str = "make mase and manage to measure it";
            Console.WriteLine("Matching words that start with 'm' and ends with 'e': ");
            showMatch(str, @"\bm\S*e\b");
            string input = "Hello   World    ";
            string pattern = "\\s+";
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);
            Console.WriteLine("Original string: {0}", input);
            Console.WriteLine("Replaced string: {0}", result);

            // Exception handeling
            Console.WriteLine("\nException handeling:");
            Program p = new Program();
            p.tryDivide(23, 0);  // Dividing by zero, catch exception

            // File I/O
            Console.WriteLine("\nFile I/O:");
            FileStream fs = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            try  // Try writing bytes to file
            {
                for (int i = 1; i <= 20; i++)
                {
                    fs.WriteByte((byte)i);
                }
            }
            catch (IOException e) // Catch IOExceptions
            {
                Console.WriteLine(e.Message + "\nCannot write to file.");
            }
            fs.Position = 0;
            try  // Try reading bytes from file
            {
                for (int i = 1; i <= 20; i++)
                {
                    Console.Write("{0} ", fs.ReadByte());  // Read bytes from file
                }
                Console.Write("\n");
            }
            catch (IOException e) // Catch IOExceptions
            {
                Console.WriteLine(e.Message + "\nCannot read from file.");
            }
            finally
            {
                fs.Close();
            }
            using (StreamWriter sw = new StreamWriter("test.txt", false))   // false = do not append
            {
                sw.WriteLine("Some text");
                sw.WriteLine("Some more text");
                sw.WriteLine("Even more text");
                sw.Close();
            }
            // Read ALL the text from the file
            using (StreamReader sr = new StreamReader("test.txt"))
            {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
            }            
            // Manipulating the Windows Filesystem using DirectoryInfo
            DirectoryInfo di = new DirectoryInfo(@"c:\dev");
            FileInfo[] fi = di.GetFiles();
            foreach (FileInfo file in fi)
            {
                Console.WriteLine("File name: {0}, Size: {1}", file.Name, file.Length);
            }



            Console.WriteLine("\n\n... hit any key to exit");
            Console.ReadKey();
        }   // Main function
    }

}
