using System;

namespace Gits
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 1 % 3;
            int d = 100;
            //公鸡
            int e = 0;
            //母鸡
            int y = 0;
            //小鸡
            int o = 0;

            d = e + y + o;
            d = a * e + b * y + c * o;

            Console.WriteLine("公鸡：{0} 母鸡{1} 小鸡{2}",e,y,o);

            Console.Read();
        }
      
        
            
        
    }
}
