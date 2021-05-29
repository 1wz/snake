using System;
using System.Collections.Generic;
using System.Text;

namespace змея
{
    class hl:fig
    {
        //List<point>pl=new List<point>();
        public hl(int x1,int x2,int y,char sym)
        {
            for(int i=x1;i<=x2;i++)
            {
                //point p = new point(i, y, sym);
                pl.Add(new point(i, y, sym));
            }
        }
        /*public void dro()
        {
            foreach (point p in pl) p.dro();
        }*/
    }
}
