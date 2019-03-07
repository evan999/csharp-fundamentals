using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;

            int j = 1000;
            byte a = (byte) j;
            //  Console.WriteLine(i);
            try
            {
                string str = "true";
                bool boo = Convert.ToBoolean(str);
                Console.WriteLine(boo);

                var number = "1234";
                byte x = Convert.ToByte(number);
                Console.WriteLine(x);
            }
            catch (Exception)
            {
                
                Console.WriteLine("The number could not be converted to a byte.");
            }
            

            // Console.WriteLine(a);

            Console.ReadKey();

        }
    }
}
