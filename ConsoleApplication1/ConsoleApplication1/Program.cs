using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class test
    {
        public void max(int[] arr)
        {
            int temp = 0;
            temp = arr[0];
            //Console.WriteLine(temp);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > temp)
                    temp = arr[i];
            }
            Console.WriteLine("max number is " + temp);
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                int n = 0;
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter numbers");
                int[]arra =new int[n];
                for (int i = 0; i < arra.Length; i++)
                {
                    //arra[i] = Console.Read();
                    arra[i] = Convert.ToInt32(Console.ReadLine());
                
                test obj = new test();
                obj.max(arra);


            }
        }
    }
}
