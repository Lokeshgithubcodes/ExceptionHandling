//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ExceptionDemo
//{
//    public class Demo2
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = {3,6,3,7,9,4,5,2,6,7,8};
//            int count = 0;
//            for(int i=0;i<arr.Length;i++)
//            {
//                if (arr[i] > 2)
//                {
//                    count++;
//                }
//            }
//            int[] brr= new int[count];
//            int index = 0;
//            for (int i = 0; i < brr.Length; i++)
//            {
//                if (brr[i] > 2)
//                {
//                    index++;
//                }
//            }
//            Array.Sort(brr);
//            Array.Reverse(brr);

//            Console.Write(brr + " ");

//        }
//    }
//}
