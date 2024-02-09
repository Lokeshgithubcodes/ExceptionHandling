using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class DivideByOddNoException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "attemted by odd no";
            }

        }
    }
    public class Demo1
    {
        static void Main(string[] args) 
        {


            try
            {
                Console.WriteLine("Enter the 1st Num:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 2nd Num");
                int b = int.Parse(Console.ReadLine());
                if(b%2==1)
                {
                   // throw new ApplicationException("Divisor can't be a odd number");
                   throw new DivideByOddNoException();
                }
                int res = a / b;
                Console.WriteLine("The result=" + res);
                
            }
            catch(FormatException ex) 
            {
                Console.WriteLine(ex.Message);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block Executed");
            }
            Console.WriteLine("End of the program");
        }
    }
}
