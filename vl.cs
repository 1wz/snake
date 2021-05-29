using System;
using System.Collections.Generic;
using System.Text;

namespace змея
{
    class vl:fig
    {
        //List<point> pl = new List<point>();
        public vl(int x, int y1,int y2,char sym)
        {
            for(int i=y1;i<=y2;i++)
            {
                pl.Add(new point(x, i, sym));
            }
        }
        /*public void dro()
        {
            foreach (point p in pl) p.dro();
        }*/
    }
}
