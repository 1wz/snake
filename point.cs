using System;
using System.Collections.Generic;
using System.Text;

namespace змея
{
    class point
    {
        public int x;
        public int y;
        public char sym;
    
        public point()
        {
            Console.WriteLine("создал точку??????????");
        }
        public point(int _x,int _y,char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public void dro()
        {
        Console.SetCursorPosition(x, y);
        Console.Write(sym);
        }
        public point move(int i,dir d)
        {
             
            if (d == dir.D)return new point(x,y+i,sym);
            else if (d == dir.L) return new point(x-1, y, sym);
            else if (d == dir.R) return new point(x+i, y , sym);
            else if (d == dir.U) return new point(x, y - i, sym);
            return new point(x, y, sym);

        }
    
    }
}
