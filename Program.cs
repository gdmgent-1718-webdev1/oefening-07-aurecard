using System;

namespace oefening_07_aurecard
{
    class Program
    {

        static int FibonacciSeries(int n)  
        {  
            int firstnumber = 0, secondnumber = 1, result = 0;  
   
            if (n == 0) return 0;  
            if (n == 1) return 1;  
   
   
            for (int i = 2; i <= n; i++)  
            {  
                result = firstnumber + secondnumber;  
                firstnumber = secondnumber;  
                secondnumber = result;  
            }  
   
            return result;  
        }

        static void Main(string[] args)
        {    
            for (int i = 0; i <= 100; i++)  
            {  
                Console.Write("{0} ", FibonacciSeries(i));  
            }  
            Console.ReadKey();  
        }
    }

}
