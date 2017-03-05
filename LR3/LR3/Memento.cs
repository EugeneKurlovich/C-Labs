using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
  public  class Memento
    {
        public string sr { private set; get; }
         
        public Memento ( string value)
        {
            sr = value;
        }

    }

    class SaveState
    {
        public Stack<Memento> History { get; private set; }
        public SaveState()
        {
            History = new Stack<Memento>();
        }
    }
}
