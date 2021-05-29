using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace змея
{
    class walls
    {
        public List<fig> figs=new List<fig>();
        public walls(int whidth,int height)
        {
            figs.Add(new hl(0, whidth - 1, 0, '#'));
            figs.Add(new hl(0, whidth - 2, height - 1, '#'));

            figs.Add(new vl(0, 0, height - 1, '#'));
            figs.Add(new vl(whidth - 1, 0, height - 2, '#'));

            foreach(fig f in figs) f.dro();

        }

    }
}
