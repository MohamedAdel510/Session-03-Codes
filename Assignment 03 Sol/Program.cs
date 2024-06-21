namespace Assignment_03_Sol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num % 4 == 0 && num % 3 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion

            #region Q2
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num > 0)
            //    Console.WriteLine("Positive");
            //else if (num < 0)
            //    Console.WriteLine("Negative");
            //else
            //    Console.WriteLine("Equal Zero");
            #endregion

            #region Q3
            //int x = int.Parse(Console.ReadLine()); 
            //int y = int.Parse(Console.ReadLine()); 
            //int z = int.Parse(Console.ReadLine()); 
            //int max, min;
            //if (x >= y && x >= z)
            //    max = x;
            //else if (y >= x && y >= z)
            //    max = y;
            //else
            //    max = z;

            //if(x <= y && x <= z)
            //    min = x;
            //else if (y <= x && y <= z)
            //    min = y;
            //else
            //    min = z;

            //Console.WriteLine($"Max element = {max}");
            //Console.WriteLine($"Min element = {min}");
            #endregion

            #region Q4
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
            #endregion

            #region Q5
            //char c = Convert.ToChar(Console.ReadLine());
            //if (c == 'a' || c == 'A' || c == 'o' || c == 'O' || c == 'u' || c == 'U' || c == 'e' || c == 'E' || c == 'i' || c == 'I')
            //    Console.WriteLine("vowel");
            //else
            //    Console.WriteLine("Constant");
            #endregion

            #region Q6
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //    Console.Write($"{i}, ");
            #endregion

            #region Q7
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //    Console.Write($"{num * i} ");
            #endregion

            #region Q8
            //int num = int.Parse(Console.ReadLine());
            //for(int i = 2; i <= num; i += 2)
            //    Console.Write($"{i} ");
            #endregion

            #region Q9
            //int BaseNum = Convert.ToInt32(Console.ReadLine());
            //int Power = Convert.ToInt32(Console.ReadLine());
            //int result = 1;
            //for (int i = 0; i < Power; i++)
            //{
            //    result *= BaseNum;
            //}
            //Console.WriteLine(result); 
            #endregion

            #region Q10
            //const int size = 5;
            //int[] marks = new int[size];
            //int sum = 0;
            //double avg;
            //for(int i = 0; i < size; i++)
            //{
            //    marks[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += marks[i];
            //}
            //avg = (double)sum / size;
            //Console.WriteLine($"Total marks = {sum}");
            //Console.WriteLine($"Average Marks = {avg}");
            //Console.WriteLine($"Persentage = {avg / 100 * 100}%");
            #endregion

            #region Q11
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 2:
            //        Console.WriteLine("Days in Month: 28");
            //        break;
            //    case 3:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 4:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 5:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 6:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 7:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 8:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 9:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 10:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 11:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 12:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    default:
            //        Console.WriteLine("invalid");
            //        break;
            //}
            #endregion

            #region Q12
            //int num1 = int.Parse(Console.ReadLine());
            //char op = char.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());

            //if (op == '+')
            //    Console.WriteLine(num1 + num2);
            //else if (op == '-')
            //    Console.WriteLine(num1 - num2);
            //else if (op == '*')
            //    Console.WriteLine(num1 * num2);
            //else if (op == '/')
            //    Console.WriteLine(num1 / num2);
            //else
            //    Console.WriteLine("Invalid operator");

            #endregion

            #region Q13
            //// 01234
            //// Ahmed  => demha
            //string s = Console.ReadLine();

            //for(int i = s.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(s[i]);
            //}
            #endregion

            #region Q14
            //int rev = 0;
            //int num = int.Parse(Console.ReadLine()); // 1234
            //while(num != 0)
            //{
            //    rev = rev * 10 + num % 10;
            //    num /= 10;
            //}
            //Console.WriteLine(rev);
            #endregion

            #region Q15
            //int stNum = int.Parse(Console.ReadLine());
            //int enNum = int.Parse(Console.ReadLine());
            //int count = 0;
            //for (int i = stNum; i <= enNum; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count++;
            //        }
            //    }
            //    if (count == 2)
            //        Console.Write($"{i} ");
            //    count = 0;
            //}
            #endregion

            #region Q16
            int DecNum = int.Parse(Console.ReadLine());
            int BinNum = 0, x = 1;
            while (DecNum != 0)
            {
                BinNum = BinNum + (DecNum % 2) * x;
                x *= 10;
                DecNum = DecNum / 2;
            }
            Console.WriteLine(BinNum);
            #endregion
        }
    }
}
