using System;
using System.Collections.Generic;
using System.Text;

namespace змея
{
    class creatF
    {   
        static Random random = new Random();
        public point food = new point(random.Next(1, Console.WindowWidth - 2), random.Next(1, Console.WindowHeight - 3), '@');
        

        public void creat(snake sn) 
        {
           // food = new point(random.Next(1, Console.WindowWidth - 2), random.Next(1, Console.WindowHeight - 3), '@');
            
            bool norm;
            do
            {
                norm = true;
                foreach (point p in sn.pl)
                {
                    if (food.x == p.x && food.y == p.y)
                    {
                        norm = false;
                        food = new point(random.Next(1, Console.WindowWidth - 2), random.Next(1, Console.WindowHeight - 3), '@');
                        break;
                    }
                }

            } while (norm == false);
            food.dro();
        }

        public creatF(snake sn)
        {
            creat(sn);
        }
        
    }
}//
   //         
