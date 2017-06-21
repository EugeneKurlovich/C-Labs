using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR8
{
    class Sort
    {
        public dynamic SortList()
        {
            Library getObj = new Library();
            List<Library> getl = new List<Library>();
            getl = getObj.GiveBook();

          var t = from i in getl
                    orderby i.AN
                    select i;

            return t;
        }

        public dynamic SortDate()
        {
            Library getObj = new Library();
            List<Library> getl = new List<Library>();
            getl = getObj.GiveBook();

            var t = from i in getl
                    orderby i.Y
                    select i;

            return t;
        }

    }
}
