using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer_to_the_question_No_04
{
    #region // Try catch 

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter anather Number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select Operation Name (Sum/Sub/Mul/Div): ");
            String ope = Console.ReadLine();
            int result = calculate(a, b, ope);
            Console.WriteLine(result);
            Console.ReadKey();

        }
        static int calculate (int a,int b, string opp)
        {
            try
            {
                if (opp == "Sum")
                {
                    return a + b;
                }
                else if (opp == "Sub")
                {
                    return a - b;
                }
                else if (opp == "Mul")
                {
                    return a * b;
                }
                else if (opp == "Div")
                {
                    return a / b;
                }
                else
                {
                    return 0;
                }
 
            }
            catch(Exception ex)
            {
                return ex.HResult;
                
            }
           

        }

    }
    #endregion
}
