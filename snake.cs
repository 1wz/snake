using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace змея
{
    class snake:fig
    {
        public dir d;
        public snake(point ta,int la,dir _d)//ubrat' _d
        {
            d = _d;
            for(int i=0;i<la;i++)
            {
                point p = ta.move(i, _d);
                pl.Add(p);
            }

        }
        public void move()
        {
            point ta = pl.First();
            pl.Remove(ta);
            pl.Add(pl.Last().move(1, d));

            ta.sym = ' ';ta.dro();
            pl.Last().dro();
        }
        public bool eat(creatF f)
        {
            point Nhead = pl.Last().move(1, d);
            if (Nhead.x == f.food.x && Nhead.y == f.food.y)
            {
                pl.Add(Nhead);
                pl.Last().dro();
                return true;
            }
            else return false;
        }
        public void uprav()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow) this.d = dir.L;
                else if (key.Key == ConsoleKey.RightArrow) this.d = dir.R;
                else if (key.Key == ConsoleKey.DownArrow) this.d = dir.D;
                else if (key.Key == ConsoleKey.UpArrow) this.d = dir.U;
            }
        }
        public bool crash(walls ww)
        {
            point Nhead = pl.Last().move(1, d);
            foreach (fig f in ww.figs)
            {
                foreach (point p in f.pl)
                {
                    if (Nhead.x == p.x && Nhead.y == p.y)
                        return true;
                }
            }
            return false;
        }
        public bool self()
        {
            point Nhead = pl.Last().move(1, d);
            for(int i=0;i<pl.Count-1;i++)
            {
                if (Nhead.x == pl[i].x && Nhead.y == pl[i].y)
                    return true;
            }
            return false;
            
        }
    }
}
