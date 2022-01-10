using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peresdacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
           
            int g = 15;
            for ( i = 0; i <= 4; i++)
            {
                g = g - 1;
            }
            Console.WriteLine(g);
            int n;
            try
            {
                int o = 0;               
                int j = 0;
                for (n = 1; n <= g; n++)
                {                  
                    int k = g / n;
                    j = n * n;
                    int u = Summa(j);
                    
                    

                }
                o = j;
                Console.WriteLine(Summa(j));


            }
            catch
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();


        }
        static int Summa(int h)
        {
            int p = h;
            int y = p + h;



            return y;
        }

    }
}