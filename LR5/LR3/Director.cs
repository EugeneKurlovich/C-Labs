using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{

    delegate void URAABE();
    delegate void DRAABE();

    class Director
    {
        public event URAABE UpRankAndAverageBalEvent;
        public event DRAABE DownRankAndAverageBalEvent;

        public void UseUpRankAndAverageBalEvent()
        {
            UpRankAndAverageBalEvent();
        }

        public void UseDownRankAndAverageBalEvent()
        {
            DownRankAndAverageBalEvent();
        }
    }
}
