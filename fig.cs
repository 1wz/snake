using System;
using System.Collections.Generic;
using System.Text;

namespace змея
{
    class fig
    {  
        public List<point> pl = new List<point>();
        public void dro()
        {
            foreach (point p in pl) p.dro();
        }
    }
}
