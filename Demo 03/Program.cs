using System.Runtime.InteropServices;

namespace Demo_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fractions and Discards
            //// Fractions
            //double x = 3.5;  // by defualt any fraction takes data type double
            //float y = 1.5f;
            //decimal z = 2.0m;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            ////Discards ==> only just for readability
            //long number = 100_000_000_000;
            //Console.WriteLine(number);
            #endregion

            #region Implicit and Exeplicit casting 
            //int X = 5;
            //long Y = X; // implicit casting [safe casting]
            //Console.WriteLine(Y);

            //long x = 5;
            //int y = (int)x;  Explicit casting [unsafe casting]
            //Console.WriteLine(y);

            //long x = 10000000000;
            //int y = (int)x;
            //Console.WriteLine(y); // y will store garbage

            //long x = 10000000000;
            //checked
            //{
            //    int y = (int) x;
            //    unchecked
            //    {
            //        Console.WriteLine(y);
            //    }
            //}

            //int x = 5;
            //double y = x;  // implicit casting
            //Console.WriteLine(y);

            //double x = 5.5;
            //int  y = (int)x;  // explicit casting 
            //Console.WriteLine(y);   

            #endregion

            #region Operators
            #region unary   ++ , --
            ////1: postfix[X++, X--]
            //int x = 10;
            //Console.WriteLine(x++); // 10  [print then incremint] 
            //Console.WriteLine(x--); // 11
            //Console.WriteLine(x);   // 10

            ////2: prefix [++X, --X]  
            //int X = 10;
            //Console.WriteLine(++X); // 11  [increment then print]
            //Console.WriteLine(--X);
            #endregion

            #region Binary operator 
            ////(+, -, *, /, %)
            //int x = 10;
            //int y = 5;
            //Console.WriteLine(x + y);
            //Console.WriteLine(x - y);
            //Console.WriteLine(x * y);
            //Console.WriteLine(x / y);
            //Console.WriteLine(x % y);
            #endregion

            #region Assignment Operator
            ////(=, -=, +=, *=, /=, %=)
            //int x = 5;
            //Console.WriteLine(x += 2);        // x = x + 2
            //Console.WriteLine(x -= 2);        // x = x - 2
            //Console.WriteLine(x *= 2);        // x = x * 2
            //Console.WriteLine(x /= 2);        // x = x / 2
            //Console.WriteLine(x %= 2);        // x = x % 2
            #endregion

            #region Logical Operators
            //// (!, && short circt, ||)
            //Console.WriteLine(!false);
            //Console.WriteLine(true && false);
            //Console.WriteLine(true || false);
            #endregion

            #region Betwise operator
            ////(& long circt, |)
            //Console.WriteLine(true & false);
            //Console.WriteLine(true | false);
            #endregion

            #region Ternary operator
            //int x = 5, y = 6;
            //string msg = (x > y ? "x is more than y" : x < y ? "x is less than y" : "x = y");
            //Console.WriteLine(msg);
            #endregion
            #endregion

            #region String formating
            //int x = 5, y = 6, sum;
            //sum = x + y;
            //string msg;
            //1: +
            // msg = "The equation is: " + x + " + " + y + " = " + sum; // not recommended
            //Console.WriteLine(msg);

            //2: composit formating                                  //   {0} {1} {2}
            // msg = string.Format("The equation is: {0} + {1} = {2}", x, y, sum);
            //Console.WriteLine(msg);

            //3: string interpolation
            // manublation operator ($)
            //msg = $"The equation is: {x} + {y} = {sum}";
            //Console.WriteLine(msg);
            #endregion

            #region Control Statment (IF - Switch)
            #region IF
            //Console.WriteLine("Please Enter month number: ");
            //int MonthNum = int.Parse(Console.ReadLine());
            //if (MonthNum == 1)
            //    Console.WriteLine("Hello Jenuary");
            //else if (MonthNum == 2)
            //    Console.WriteLine("Hello Febraury");
            //else if (MonthNum == 3)
            //    Console.WriteLine("Hello March");
            //else if (MonthNum == 4)
            //    Console.WriteLine("Hello April");
            //else
            //    Console.WriteLine("The month is not in the first Quarter");
            #endregion

            #region Switch 
            //(jumb table)
            //Console.WriteLine("Please Enter month number: ");
            //int MonthNum = int.Parse(Console.ReadLine());
            //switch (MonthNum)
            //{
            //    case 1:
            //        Console.WriteLine("Hello Jenuary");
            //        break;
            //    case 2:
            //    Console.WriteLine("Hello febraury");
            //        break;
            //    case 3:
            //        Console.WriteLine("Hello March");
            //        break;
            //    case 4:
            //        Console.WriteLine("Hello April");
            //        break;
            //    default:
            //        Console.WriteLine("The month is not in the first Quarter");
            //        break;
            //}

            //==============================================

            //Console.WriteLine("Please Enter budgt: ");
            //int budget = Convert.ToInt32(Console.ReadLine());
            //switch (budget)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 03");
            //        goto case 2000;
            //        break;
            //    case 2000:
            //        Console.WriteLine("Option 02");
            //        goto case 1000;
            //        break;
            //    case 1000:
            //        Console.WriteLine("Option 01");
            //        break;
            //}
            #endregion

            #region Switch statment in  C# 7, C# 8, C#9
            #region C#7 (when) 
            //Object input = new Object();
            //input = "Mohamed";
            //switch (input)
            //{
            //    case int Number when Number > 1 && Number < 10:
            //        Console.WriteLine($"Integer input: {Number}");
            //        break;
            //    case double Number:
            //        Console.WriteLine($"integer input: {Number}");
            //        break;
            //    case string Name:
            //        Console.WriteLine($"String input: {Name}");
            //        break;
            //}
            #endregion

            #region C# 8
            //string option = "1";
            //string msg = "";
            //msg = option switch
            //{
            //    "1" => "Using option 1",
            //    "2" => "using option 2",
            //    "3" => "using option 3",
            //    _ => "using no option"
            //};
            //Console.WriteLine(msg);
            #endregion

            #region C# 9
            //string option = "1";
            //string msg = "";
            //msg = option switch
            //{
            //    "1" or "2" => "Using option 1",
            //    "3" => "using option 3",
            //    _ => "using no option"
            //};
            Console.WriteLine(msg);
            #endregion
            #endregion
            #endregion
            
        }
    }
}
