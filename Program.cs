using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace змея
{
    class Program
    {
        static void Main(string[] args)
        {
            int whidth = 80, height = 25;
            Console.SetWindowSize(whidth, height);
            Console.SetBufferSize(whidth, height);
            walls ww = new walls(whidth, height);
            
             point p1 = new point(2,20,'*');
            snake sn = new snake(p1, 10,dir.R);
            sn.dro();
            creatF f = new creatF(sn);
            
            
            while(true)
            {
                sn.uprav();

                if (sn.eat(f)) f.creat(sn);
                else if (sn.crash(ww) || sn.self()) break;
                else sn.move();
                Thread.Sleep(100);
                
            }
            
            //Console.ReadLine();

            /*

            
            Console.ReadLine();*/
            //Console.SetCursorPosition(0, 19);


            /*
                         point p2 = new point(2,4,'#');
                         p2.dro();
              List<point> lp = new List<point>();
                         lp.Add(p1);
                         lp.Add(p2);

                         foreach (point i in lp)
                         {
                            Console.WriteLine(i.x);
                         }

                        */
        }
        /*static void dro(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);





        List<int> fis = new List<int>();
            fis.Add(whidth); whidth = 5;
            Console.Write(whidth+"        "+fis[0]);
            Console.ReadLine();
        }*/
    }
}
     //Console.WriteLine(x2);
            //Console.ReadLine();